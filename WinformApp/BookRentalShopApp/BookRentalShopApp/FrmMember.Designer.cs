
namespace BookRentalShopApp
{
    partial class FrmMember
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
            this.GrbDetail = new System.Windows.Forms.GroupBox();
            this.CboLevels = new MetroFramework.Controls.MetroComboBox();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.TxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.TxtId = new MetroFramework.Controls.MetroTextBox();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TxtMobile = new MetroFramework.Controls.MetroTextBox();
            this.TxtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.TxtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.GrbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbDetail
            // 
            this.GrbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbDetail.Controls.Add(this.CboLevels);
            this.GrbDetail.Controls.Add(this.TxtIdx);
            this.GrbDetail.Controls.Add(this.metroLabel10);
            this.GrbDetail.Controls.Add(this.TxtPassword);
            this.GrbDetail.Controls.Add(this.metroLabel8);
            this.GrbDetail.Controls.Add(this.TxtId);
            this.GrbDetail.Controls.Add(this.TxtEmail);
            this.GrbDetail.Controls.Add(this.metroLabel5);
            this.GrbDetail.Controls.Add(this.metroLabel6);
            this.GrbDetail.Controls.Add(this.TxtMobile);
            this.GrbDetail.Controls.Add(this.TxtAddress);
            this.GrbDetail.Controls.Add(this.metroLabel3);
            this.GrbDetail.Controls.Add(this.metroLabel4);
            this.GrbDetail.Controls.Add(this.BtnSave);
            this.GrbDetail.Controls.Add(this.BtnNew);
            this.GrbDetail.Controls.Add(this.BtnDelete);
            this.GrbDetail.Controls.Add(this.TxtName);
            this.GrbDetail.Controls.Add(this.metroLabel2);
            this.GrbDetail.Controls.Add(this.metroLabel1);
            this.GrbDetail.Location = new System.Drawing.Point(413, 70);
            this.GrbDetail.Name = "GrbDetail";
            this.GrbDetail.Size = new System.Drawing.Size(364, 421);
            this.GrbDetail.TabIndex = 0;
            this.GrbDetail.TabStop = false;
            this.GrbDetail.Text = "상세";
            // 
            // CboLevels
            // 
            this.CboLevels.FormattingEnabled = true;
            this.CboLevels.ItemHeight = 23;
            this.CboLevels.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "S"});
            this.CboLevels.Location = new System.Drawing.Point(107, 103);
            this.CboLevels.Name = "CboLevels";
            this.CboLevels.PromptText = "레벨";
            this.CboLevels.Size = new System.Drawing.Size(236, 29);
            this.CboLevels.TabIndex = 3;
            this.CboLevels.UseSelectable = true;
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(107, 25);
            this.TxtIdx.MaxLength = 32767;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.PromptText = "순번";
            this.TxtIdx.ReadOnly = true;
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(236, 23);
            this.TxtIdx.TabIndex = 1;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMark = "순번";
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(52, 25);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(48, 19);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "순번 : ";
            // 
            // TxtPassword
            // 
            // 
            // 
            // 
            this.TxtPassword.CustomButton.Image = null;
            this.TxtPassword.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtPassword.CustomButton.Name = "";
            this.TxtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPassword.CustomButton.TabIndex = 1;
            this.TxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPassword.CustomButton.UseSelectable = true;
            this.TxtPassword.CustomButton.Visible = false;
            this.TxtPassword.Lines = new string[0];
            this.TxtPassword.Location = new System.Drawing.Point(105, 312);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '●';
            this.TxtPassword.PromptText = "비밀번호";
            this.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.ShortcutsEnabled = true;
            this.TxtPassword.Size = new System.Drawing.Size(236, 23);
            this.TxtPassword.TabIndex = 8;
            this.TxtPassword.UseSelectable = true;
            this.TxtPassword.WaterMark = "비밀번호";
            this.TxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPassword.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(24, 312);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "비밀번호 : ";
            // 
            // TxtId
            // 
            // 
            // 
            // 
            this.TxtId.CustomButton.Image = null;
            this.TxtId.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.TxtId.CustomButton.Name = "";
            this.TxtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtId.CustomButton.TabIndex = 1;
            this.TxtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtId.CustomButton.UseSelectable = true;
            this.TxtId.CustomButton.Visible = false;
            this.TxtId.Lines = new string[0];
            this.TxtId.Location = new System.Drawing.Point(104, 271);
            this.TxtId.MaxLength = 32767;
            this.TxtId.Name = "TxtId";
            this.TxtId.PasswordChar = '\0';
            this.TxtId.PromptText = "아이디";
            this.TxtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtId.SelectedText = "";
            this.TxtId.SelectionLength = 0;
            this.TxtId.SelectionStart = 0;
            this.TxtId.ShortcutsEnabled = true;
            this.TxtId.Size = new System.Drawing.Size(237, 23);
            this.TxtId.TabIndex = 7;
            this.TxtId.UseSelectable = true;
            this.TxtId.WaterMark = "아이디";
            this.TxtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtId.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(105, 230);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PromptText = "이메일";
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(236, 23);
            this.TxtEmail.TabIndex = 6;
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMark = "이메일";
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(38, 271);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "아이디 : ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(38, 230);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "이메일 : ";
            // 
            // TxtMobile
            // 
            // 
            // 
            // 
            this.TxtMobile.CustomButton.Image = null;
            this.TxtMobile.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.TxtMobile.CustomButton.Name = "";
            this.TxtMobile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMobile.CustomButton.TabIndex = 1;
            this.TxtMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMobile.CustomButton.UseSelectable = true;
            this.TxtMobile.CustomButton.Visible = false;
            this.TxtMobile.Lines = new string[0];
            this.TxtMobile.Location = new System.Drawing.Point(105, 189);
            this.TxtMobile.MaxLength = 32767;
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.PasswordChar = '\0';
            this.TxtMobile.PromptText = "연락처";
            this.TxtMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMobile.SelectedText = "";
            this.TxtMobile.SelectionLength = 0;
            this.TxtMobile.SelectionStart = 0;
            this.TxtMobile.ShortcutsEnabled = true;
            this.TxtMobile.Size = new System.Drawing.Size(237, 23);
            this.TxtMobile.TabIndex = 5;
            this.TxtMobile.UseSelectable = true;
            this.TxtMobile.WaterMark = "연락처";
            this.TxtMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMobile.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtAddress
            // 
            // 
            // 
            // 
            this.TxtAddress.CustomButton.Image = null;
            this.TxtAddress.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtAddress.CustomButton.Name = "";
            this.TxtAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddress.CustomButton.TabIndex = 1;
            this.TxtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddress.CustomButton.UseSelectable = true;
            this.TxtAddress.CustomButton.Visible = false;
            this.TxtAddress.Lines = new string[0];
            this.TxtAddress.Location = new System.Drawing.Point(106, 148);
            this.TxtAddress.MaxLength = 32767;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.PasswordChar = '\0';
            this.TxtAddress.PromptText = "주소";
            this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddress.SelectedText = "";
            this.TxtAddress.SelectionLength = 0;
            this.TxtAddress.SelectionStart = 0;
            this.TxtAddress.ShortcutsEnabled = true;
            this.TxtAddress.Size = new System.Drawing.Size(236, 23);
            this.TxtAddress.TabIndex = 4;
            this.TxtAddress.UseSelectable = true;
            this.TxtAddress.WaterMark = "주소";
            this.TxtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAddress.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 189);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "연락처 : ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(52, 148);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "주소 : ";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(226, 375);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 30);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(145, 375);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 30);
            this.BtnNew.TabIndex = 10;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(64, 375);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 30);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtName
            // 
            // 
            // 
            // 
            this.TxtName.CustomButton.Image = null;
            this.TxtName.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.TxtName.CustomButton.Name = "";
            this.TxtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtName.CustomButton.TabIndex = 1;
            this.TxtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtName.CustomButton.UseSelectable = true;
            this.TxtName.CustomButton.Visible = false;
            this.TxtName.Lines = new string[0];
            this.TxtName.Location = new System.Drawing.Point(107, 66);
            this.TxtName.MaxLength = 32767;
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.PromptText = "이름";
            this.TxtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtName.SelectedText = "";
            this.TxtName.SelectionLength = 0;
            this.TxtName.SelectionStart = 0;
            this.TxtName.ShortcutsEnabled = true;
            this.TxtName.Size = new System.Drawing.Size(236, 23);
            this.TxtName.TabIndex = 2;
            this.TxtName.UseSelectable = true;
            this.TxtName.WaterMark = "이름";
            this.TxtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtName.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(52, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "레벨 : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "이름 : ";
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(23, 77);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 23;
            this.DgvData.Size = new System.Drawing.Size(371, 414);
            this.DgvData.TabIndex = 1;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            // 
            // FrmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.ControlBox = false;
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.GrbDetail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMember";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "회원 관리";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMember_Load);
            this.Resize += new System.EventHandler(this.FrmMember_Resize);
            this.GrbDetail.ResumeLayout(false);
            this.GrbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDetail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroTextBox TxtName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView DgvData;
        private MetroFramework.Controls.MetroTextBox TxtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox TxtId;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox TxtMobile;
        private MetroFramework.Controls.MetroTextBox TxtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox CboLevels;
    }
}