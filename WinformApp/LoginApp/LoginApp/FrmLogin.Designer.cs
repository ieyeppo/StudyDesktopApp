
namespace LoginApp
{
    partial class FrmLogin
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblId = new System.Windows.Forms.Label();
            this.LblPw = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtPw = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(36, 52);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(16, 12);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "ID";
            // 
            // LblPw
            // 
            this.LblPw.AutoSize = true;
            this.LblPw.Location = new System.Drawing.Point(36, 109);
            this.LblPw.Name = "LblPw";
            this.LblPw.Size = new System.Drawing.Size(62, 12);
            this.LblPw.TabIndex = 1;
            this.LblPw.Text = "Password";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(112, 47);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(312, 21);
            this.TxtId.TabIndex = 2;
            // 
            // TxtPw
            // 
            this.TxtPw.Location = new System.Drawing.Point(112, 103);
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.PasswordChar = '●';
            this.TxtPw.Size = new System.Drawing.Size(312, 21);
            this.TxtPw.TabIndex = 3;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(334, 154);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(90, 28);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Enabled = false;
            this.TxtResult.Location = new System.Drawing.Point(112, 206);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(312, 21);
            this.TxtResult.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 274);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPw);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblPw);
            this.Controls.Add(this.LblId);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblPw;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtPw;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

