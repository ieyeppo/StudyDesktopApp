
namespace RadioBoxWinApp
{
    partial class FrmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.GbCountry = new System.Windows.Forms.GroupBox();
            this.RdbOther = new System.Windows.Forms.RadioButton();
            this.RdbJapen = new System.Windows.Forms.RadioButton();
            this.RdbChina = new System.Windows.Forms.RadioButton();
            this.RdbKorea = new System.Windows.Forms.RadioButton();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.RdbFemail = new System.Windows.Forms.RadioButton();
            this.RdbMale = new System.Windows.Forms.RadioButton();
            this.GbCountry.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "결과";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GbCountry
            // 
            this.GbCountry.Controls.Add(this.RdbOther);
            this.GbCountry.Controls.Add(this.RdbJapen);
            this.GbCountry.Controls.Add(this.RdbChina);
            this.GbCountry.Controls.Add(this.RdbKorea);
            this.GbCountry.Location = new System.Drawing.Point(12, 12);
            this.GbCountry.Name = "GbCountry";
            this.GbCountry.Size = new System.Drawing.Size(200, 228);
            this.GbCountry.TabIndex = 7;
            this.GbCountry.TabStop = false;
            this.GbCountry.Text = "국가";
            // 
            // RdbOther
            // 
            this.RdbOther.AutoSize = true;
            this.RdbOther.Location = new System.Drawing.Point(27, 171);
            this.RdbOther.Name = "RdbOther";
            this.RdbOther.Size = new System.Drawing.Size(79, 16);
            this.RdbOther.TabIndex = 8;
            this.RdbOther.TabStop = true;
            this.RdbOther.Text = "그 외 국가";
            this.RdbOther.UseVisualStyleBackColor = true;
            // 
            // RdbJapen
            // 
            this.RdbJapen.AutoSize = true;
            this.RdbJapen.Location = new System.Drawing.Point(27, 131);
            this.RdbJapen.Name = "RdbJapen";
            this.RdbJapen.Size = new System.Drawing.Size(47, 16);
            this.RdbJapen.TabIndex = 7;
            this.RdbJapen.TabStop = true;
            this.RdbJapen.Text = "일본";
            this.RdbJapen.UseVisualStyleBackColor = true;
            // 
            // RdbChina
            // 
            this.RdbChina.AutoSize = true;
            this.RdbChina.Location = new System.Drawing.Point(27, 91);
            this.RdbChina.Name = "RdbChina";
            this.RdbChina.Size = new System.Drawing.Size(47, 16);
            this.RdbChina.TabIndex = 6;
            this.RdbChina.TabStop = true;
            this.RdbChina.Text = "중국";
            this.RdbChina.UseVisualStyleBackColor = true;
            // 
            // RdbKorea
            // 
            this.RdbKorea.AutoSize = true;
            this.RdbKorea.Location = new System.Drawing.Point(27, 51);
            this.RdbKorea.Name = "RdbKorea";
            this.RdbKorea.Size = new System.Drawing.Size(71, 16);
            this.RdbKorea.TabIndex = 5;
            this.RdbKorea.TabStop = true;
            this.RdbKorea.Text = "대한민국";
            this.RdbKorea.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.RdbFemail);
            this.gbGender.Controls.Add(this.RdbMale);
            this.gbGender.Location = new System.Drawing.Point(218, 12);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(200, 107);
            this.gbGender.TabIndex = 8;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "성별";
            // 
            // RdbFemail
            // 
            this.RdbFemail.AutoSize = true;
            this.RdbFemail.Location = new System.Drawing.Point(115, 51);
            this.RdbFemail.Name = "RdbFemail";
            this.RdbFemail.Size = new System.Drawing.Size(47, 16);
            this.RdbFemail.TabIndex = 8;
            this.RdbFemail.TabStop = true;
            this.RdbFemail.Text = "여자";
            this.RdbFemail.UseVisualStyleBackColor = true;
            // 
            // RdbMale
            // 
            this.RdbMale.AutoSize = true;
            this.RdbMale.Location = new System.Drawing.Point(34, 51);
            this.RdbMale.Name = "RdbMale";
            this.RdbMale.Size = new System.Drawing.Size(47, 16);
            this.RdbMale.TabIndex = 7;
            this.RdbMale.TabStop = true;
            this.RdbMale.Text = "남자";
            this.RdbMale.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 252);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.GbCountry);
            this.Controls.Add(this.button1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.GbCountry.ResumeLayout(false);
            this.GbCountry.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GbCountry;
        private System.Windows.Forms.RadioButton RdbOther;
        private System.Windows.Forms.RadioButton RdbJapen;
        private System.Windows.Forms.RadioButton RdbChina;
        private System.Windows.Forms.RadioButton RdbKorea;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton RdbFemail;
        private System.Windows.Forms.RadioButton RdbMale;
    }
}

