using MetroFramework;
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
        private bool isLogin = false;

        public FrmLogin()
        {
            InitializeComponent();
            isLogin = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //빈칸 예외처리
            if(string.IsNullOrEmpty(TxtId.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("아이디/패스워드를 입력하세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //관리자 로그인
            else if (TxtId.Text.Equals("admin") && TxtPassword.Text.Equals("1234"))
            {
                isLogin = true;
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

                        //SqlCommand 생성
                        SqlCommand cmd = new SqlCommand();

                        //SqlInjection 해킹 막기위해서 사용
                        SqlParameter param;

                        //SqlDataReader 실행(1)
                        SqlDataReader reader = cmd.ExecuteReader();

                        //reader로 처리...

                    }


                    //로그인 실패MetroMessageBox.Show(this, "아이디 또는 비밀번호를 다시 확인해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, $"Error : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
