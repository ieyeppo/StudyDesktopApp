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
    public partial class FrmDivCode : MetroForm
    {
        private bool isNew = false; //false(수정) / true(신규)

        /// <summary>
        /// 생성자
        /// </summary>
        public FrmDivCode()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 프로그램 시작시 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            isNew = true;
            RefreshData();
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

                    var query = "SELECT [Division], " +
                                " [Names] " +
                                " FROM[dbo].[divtbl]";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "divtbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "divtbl";

                    isNew = false;
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// FrmDivCode 창 높이 조절
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDivCode_Resize(object sender, EventArgs e)
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
            if(e.RowIndex > -1) //선택한 값이 존재하면
            {
                var selData = DgvData.Rows[e.RowIndex];
                TxtDivision.Text = selData.Cells[0].Value.ToString();
                TxtNames.Text = selData.Cells[1].Value.ToString();
                TxtDivision.ReadOnly = true;
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

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "DELETE FROM [dbo].[divtbl] " +
                                " WHERE [Division] = @Division";

                    cmd.CommandText = query;

                    SqlParameter pDivision = new SqlParameter("@Division", SqlDbType.VarChar, 8);
                    pDivision.Value = TxtDivision.Text;
                    cmd.Parameters.Add(pDivision);

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

            RefreshData();
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
        /// 텍스트 박스 초기화 메서드
        /// </summary>
        private void ClearInputs()
        {
            TxtDivision.Text = TxtNames.Text = "";
            TxtDivision.ReadOnly = false;
            isNew = true;
        }

        /// <summary>
        /// 저장 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Validation 체크
            if(!CheckValidation()) return;

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
                        query = "INSERT INTO [dbo].[divtbl] " +
                                " VALUES " +
                                "(@Division, @Names)";
                    }
                    else //update
                    {
                        query = "UPDATE [dbo].[divtbl] " +
                                " SET [Names] = @Names " +
                                " WHERE [Division] = @Division";
                    }

                    cmd.CommandText = query;

                    SqlParameter pDivision = new SqlParameter("@Division", SqlDbType.VarChar, 8);
                    pDivision.Value = TxtDivision.Text;
                    cmd.Parameters.Add(pDivision);

                    SqlParameter pNames = new SqlParameter("@Names", SqlDbType.NVarChar, 45);
                    pNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(pNames);


                    var result = cmd.ExecuteNonQuery();

                    if(result == 1)
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

            RefreshData();
            ClearInputs();
        }

        /// <summary>
        /// 텍스트 박스 빈칸 오류처리 메서드
        /// </summary>
        /// <returns></returns>
        private bool CheckValidation()
        {
            //Validation
            if (string.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text))
            {
                MetroMessageBox.Show(this, "빈값은 저장 할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
