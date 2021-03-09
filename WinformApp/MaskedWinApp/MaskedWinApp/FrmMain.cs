using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedWinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string result = string.Empty;

            result = $"입사일 : {TxtDate.Text}\n";
            result += $"우편번호 : {TxtZipCode.Text}\n";
            result += $"주소 : {TxtAddr.Text}\n";
            result += $"연락처 : {TxtMobile.Text}\n";
            result += $"주민번호 : {TxtRegisterNum.Text}\n";
            result += $"이메일 : {TxtEmail.Text}\n";

            MessageBox.Show(result, "개인정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
