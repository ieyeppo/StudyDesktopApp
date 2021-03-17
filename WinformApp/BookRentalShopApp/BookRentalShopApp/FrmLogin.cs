﻿using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmLogin : MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var strUserID = "";

            //빈칸 예외처리
            if(string.IsNullOrEmpty(TxtId.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("아이디/패스워드를 입력하세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //관리자 로그인
            else if (TxtId.Text.Equals("admin") && TxtPassword.Text.Equals("1234"))
            {
                Close();
                MetroMessageBox.Show(this, "관리자 로그인 성공", "확인", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            //회원 로그인
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                    {
                        if (conn.State == ConnectionState.Closed) conn.Open();

                        var query = "SELECT userID FROM membertbl " +
                                    " WHERE userID = @userID " +
                                    " AND passwords = @passwords ";

                        //SqlCommand 생성
                        SqlCommand cmd = new SqlCommand(query, conn);

                        //SqlInjection 해킹 막기위해서 사용
                        SqlParameter pUserID = new SqlParameter("@userId", SqlDbType.VarChar, 20);
                        pUserID.Value = TxtId.Text;
                        cmd.Parameters.Add(pUserID);

                        SqlParameter pPasswords = new SqlParameter("@passwords", SqlDbType.VarChar, 20);
                        pPasswords.Value = TxtPassword.Text;
                        cmd.Parameters.Add(pPasswords);

                        //SqlDataReader 실행(1)
                        SqlDataReader reader = cmd.ExecuteReader();

                        //reader로 처리...
                        reader.Read();
                        strUserID = reader["userID"] != null ? reader["userID"].ToString() : "";
                        reader.Close(); //!!

                        //확인
                        if (string.IsNullOrEmpty(strUserID))
                        {
                            MetroMessageBox.Show(this, "접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            //로그인 정보 남기기
                            var updateQuery = $@"update membertbl set
                                                        lastLoginDt = GETDATE() 
                                                        , loginIpAddr = '{Helper.Common.GetLocalIp()}' 
                                                    where userID = '{strUserID}' ";

                            cmd.CommandText = updateQuery;
                            cmd.ExecuteNonQuery();

                            MetroMessageBox.Show(this, "접속성공", "로그인성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, $"Error : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) TxtPassword.Focus();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnLogin_Click(sender, e);
        }

    }
}
