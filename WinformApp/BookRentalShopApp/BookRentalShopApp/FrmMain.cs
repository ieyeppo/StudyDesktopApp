using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        private void MntEXit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if(DialogResul    t.Yes)
            Environment.Exit(0);
        }

    }
}
