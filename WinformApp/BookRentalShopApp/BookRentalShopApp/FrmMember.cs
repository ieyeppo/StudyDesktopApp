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
    public partial class FrmMember : MetroForm
    {
        #region 전역변수 영역
        private bool isNew = false; //false(수정) / true(신규)
        #endregion


        #region 이벤트 영역

        /// <summary>
        /// 생성자
        /// </summary>
        public FrmMember()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 프로그램 시작시 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMember_Load(object sender, EventArgs e)
        {
            isNew = true;
            RefreshData();
        }

        /// <summary>
        /// FrmMember 창 높이 조절
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMember_Resize(object sender, EventArgs e)
        {
            DgvData.Height = DgvData.Height = this.ClientRectangle.Height - 90;
            GrbDetail.Height = this.ClientRectangle.Height - 90;
        }

        /// <summary>
        /// DgvData 셀 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //선택한 값이 존재하면
            {
                var selData = DgvData.Rows[e.RowIndex];
                TxtIdx.Text = selData.Cells[0].Value.ToString();
                TxtName.Text = selData.Cells[1].Value.ToString();

                CboLevels.SelectedItem = selData.Cells[2].Value;

                TxtAddress.Text = selData.Cells[3].Value.ToString();
                TxtMobile.Text = selData.Cells[4].Value.ToString();
                TxtEmail.Text = selData.Cells[5].Value.ToString();
                TxtId.Text = selData.Cells[6].Value.ToString();
                TxtPassword.Text = selData.Cells[7].Value.ToString();

                TxtId.ReadOnly = true;
                isNew = false;
            }
        }

        /// <summary>
        /// 삭제 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Validation
            if (!CheckValidation()) return;

            if (MetroMessageBox.Show(this, "삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DeleteData();
            RefreshData();
            ClearInputs();
        }

        /// <summary>
        /// 신규 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        /// <summary>
        /// 저장 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Validation 체크
            if (!CheckValidation()) return;

            SaveData();
            RefreshData();
            ClearInputs();
        }

        #endregion


        #region 커스텀 메서드 영역

        /// <summary>
        /// 데이터 삭제 메서드
        /// </summary>
        private void DeleteData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "DELETE FROM [dbo].[membertbl] " +
                                " WHERE Idx = @Idx";

                    cmd.CommandText = query;

                    SqlParameter pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    pIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(pIdx);

                    var result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        //저장성공
                        MetroMessageBox.Show(this, "데이터 삭제 성공", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //저장실패
                        MetroMessageBox.Show(this, "데이터 삭제 실패", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 데이터 저장 메서드
        /// </summary>
        private void SaveData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "";

                    if (isNew) //insert
                    {
                        query = @"INSERT INTO [dbo].[membertbl]
                                           ([Names]
                                           ,[Levels]
                                           ,[Addr]
                                           ,[Mobile]
                                           ,[Email]
                                           ,[userID]
                                           ,[passwords])
                                   VALUES
                                           (@Names
                                           ,@Levels
                                           ,@Addr
                                           ,@Mobile
                                           ,@Email
                                           ,@userID
                                           ,@passwords)";
                    }
                    else //update
                    {
                        query = @"UPDATE [dbo].[membertbl]
                                   SET [Names] = @Names
                                      ,[Levels] = @Levels
                                      ,[Addr] = @Addr
                                      ,[Mobile] = @Mobile
                                      ,[Email] = @Email
                                      ,[userID] = @userID
                                      ,[passwords] = @passwords
                                 WHERE Idx = @Idx;";
                    }

                    cmd.CommandText = query;

                    if (!isNew)
                    {
                        var pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                        pIdx.Value = TxtIdx.Text;
                        cmd.Parameters.Add(pIdx);
                    }

                    var pNames = new SqlParameter("@Names", SqlDbType.NVarChar, 50);
                    pNames.Value = TxtName.Text;
                    cmd.Parameters.Add(pNames);

                    var pLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                    pLevels.Value = CboLevels.SelectedItem.ToString();
                    cmd.Parameters.Add(pLevels);

                    var pAddr = new SqlParameter("@Addr", SqlDbType.NVarChar, 100);
                    pAddr.Value = TxtAddress.Text;
                    cmd.Parameters.Add(pAddr);

                    var pMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);
                    pMobile.Value = TxtMobile.Text;
                    cmd.Parameters.Add(pMobile);

                    var pEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                    pEmail.Value = TxtEmail.Text;
                    cmd.Parameters.Add(pEmail);

                    var pId = new SqlParameter("@userID", SqlDbType.VarChar, 20);
                    pId.Value = TxtId.Text;
                    cmd.Parameters.Add(pId);

                    var pPassword = new SqlParameter("@passwords", SqlDbType.VarChar, 100);
                    pPassword.Value = TxtPassword.Text;
                    cmd.Parameters.Add(pPassword);

                    var result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        //저장성공
                        MetroMessageBox.Show(this, "데이터 저장 성공", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //저장실패
                        MetroMessageBox.Show(this, "데이터 저장 실패", "저장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 데이터 조회
        /// </summary>
        private void RefreshData()
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = @"SELECT [Idx]
                                      ,[Names]
                                      ,[Levels]
                                      ,[Addr]
                                      ,[Mobile]
                                      ,[Email]
                                      ,[userID]
                                      ,[lastLoginDt]
                                      ,[loginIpAddr]
                                  FROM[dbo].[membertbl]";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "membertbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "membertbl";

                    isNew = false;
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 텍스트 박스 초기화 메서드
        /// </summary>
        private void ClearInputs()
        {
            TxtIdx.Text = TxtName.Text = TxtMobile.Text = TxtAddress.Text = TxtEmail.Text = TxtId.Text = TxtPassword.Text = "";
            CboLevels.SelectedIndex = -1;
            TxtName.ReadOnly = false;
            isNew = true;
        }

        /// <summary>
        /// 텍스트 박스 빈칸 오류처리 메서드
        /// </summary>
        /// <returns></returns>
        private bool CheckValidation()
        {
            //Validation
            if (!isNew) { string.IsNullOrEmpty(TxtIdx.Text); }
            if (string.IsNullOrEmpty(TxtName.Text) || CboLevels.SelectedIndex == -1 || string.IsNullOrEmpty(TxtAddress.Text)
                || string.IsNullOrEmpty(TxtMobile.Text) || string.IsNullOrEmpty(TxtEmail.Text) || string.IsNullOrEmpty(TxtId.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "빈값은 저장 할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion
    }
}
