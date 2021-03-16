
namespace BookRentalShopApp
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtId = new MetroFramework.Controls.MetroTextBox();
            this.TxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.BtnLogin = new MetroFramework.Controls.MetroButton();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(104, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(62, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password";
            // 
            // TxtId
            // 
            // 
            // 
            // 
            this.TxtId.CustomButton.Image = null;
            this.TxtId.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.TxtId.CustomButton.Name = "";
            this.TxtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtId.CustomButton.TabIndex = 1;
            this.TxtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtId.CustomButton.UseSelectable = true;
            this.TxtId.CustomButton.Visible = false;
            this.TxtId.Lines = new string[0];
            this.TxtId.Location = new System.Drawing.Point(140, 83);
            this.TxtId.MaxLength = 32767;
            this.TxtId.Name = "TxtId";
            this.TxtId.PasswordChar = '\0';
            this.TxtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtId.SelectedText = "";
            this.TxtId.SelectionLength = 0;
            this.TxtId.SelectionStart = 0;
            this.TxtId.ShortcutsEnabled = true;
            this.TxtId.Size = new System.Drawing.Size(174, 23);
            this.TxtId.TabIndex = 2;
            this.TxtId.UseSelectable = true;
            this.TxtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtId_KeyPress);
            // 
            // TxtPassword
            // 
            // 
            // 
            // 
            this.TxtPassword.CustomButton.Image = null;
            this.TxtPassword.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.TxtPassword.CustomButton.Name = "";
            this.TxtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPassword.CustomButton.TabIndex = 1;
            this.TxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPassword.CustomButton.UseSelectable = true;
            this.TxtPassword.CustomButton.Visible = false;
            this.TxtPassword.Lines = new string[0];
            this.TxtPassword.Location = new System.Drawing.Point(140, 114);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '●';
            this.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.ShortcutsEnabled = true;
            this.TxtPassword.Size = new System.Drawing.Size(174, 23);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSelectable = true;
            this.TxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(112, 162);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 29);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.UseSelectable = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(213, 162);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 29);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseSelectable = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 217);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtId;
        private MetroFramework.Controls.MetroTextBox TxtPassword;
        private MetroFramework.Controls.MetroButton BtnLogin;
        private MetroFramework.Controls.MetroButton BtnCancel;
    }
}