using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBoxWinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = string.Empty;

            if (!RdbKorea.Checked && !RdbChina.Checked && !RdbJapen.Checked && !RdbOther.Checked)
            {
                result = "국가를 선택해주세요.";
            }
            else
            {
                if (RdbKorea.Checked) result = "국적 : 대한민국\n";
                else if (RdbChina.Checked) result = "국적 : 중국\n";
                else if (RdbJapen.Checked) result = "국적 : 일본\n";
                else if (RdbOther.Checked) result = "국적 : 그 외 지역\n";
            }

            MessageBox.Show(result, "결과");

            if (!RdbMale.Checked && !RdbFemail.Checked)
                result = "성별을 선택해주세요.";
            else
            {
                if (RdbMale.Checked) result = "성별 : 남자\n";
                else if (RdbFemail.Checked) result = "성별 : 여자\n";
            }

            MessageBox.Show(result, "결과");
        }
    }
}
