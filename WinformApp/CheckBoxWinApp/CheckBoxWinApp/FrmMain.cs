using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxWinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            string checkState = string.Empty;
            string summary = $"좋아하는 과일은 : ";

            List<CheckBox> boxes = new List<CheckBox> { ChkApple, ChkStroberry, ChkCherry, ChkBanana, ChkOrange, ChkPear };

            foreach(var fruit in boxes)
            {
                checkState += $"{fruit.Text} : {fruit.Checked}\n";

                if (fruit.Checked) summary += fruit.Text + " ";
            }
            MessageBox.Show(checkState, "체크상태");
            MessageBox.Show(summary, "좋아하는 과일 리스트");
        }
    }
}
