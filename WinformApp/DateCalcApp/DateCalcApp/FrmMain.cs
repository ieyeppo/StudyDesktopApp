using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateCalcApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void DtpBirthDay_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime birthDay = DtpBirthDay.Value;

            TxtResult.Text = $"{today.Subtract(birthDay).TotalDays : #,###}";
            TxtYear.Text = (today.Subtract(birthDay).TotalDays / 365).ToString("0");
        }
    }
}
