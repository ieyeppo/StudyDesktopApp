
namespace AlarmClockApp
{
    partial class FrmAlarm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TapAlram = new System.Windows.Forms.TabPage();
            this.TapDigitalClock = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TapAlram);
            this.tabControl1.Controls.Add(this.TapDigitalClock);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(414, 307);
            this.tabControl1.TabIndex = 0;
            // 
            // TapAlram
            // 
            this.TapAlram.Location = new System.Drawing.Point(4, 22);
            this.TapAlram.Name = "TapAlram";
            this.TapAlram.Padding = new System.Windows.Forms.Padding(3);
            this.TapAlram.Size = new System.Drawing.Size(406, 281);
            this.TapAlram.TabIndex = 0;
            this.TapAlram.Text = "알람설정";
            this.TapAlram.UseVisualStyleBackColor = true;
            // 
            // TapDigitalClock
            // 
            this.TapDigitalClock.Location = new System.Drawing.Point(4, 22);
            this.TapDigitalClock.Name = "TapDigitalClock";
            this.TapDigitalClock.Padding = new System.Windows.Forms.Padding(3);
            this.TapDigitalClock.Size = new System.Drawing.Size(406, 281);
            this.TapDigitalClock.TabIndex = 1;
            this.TapDigitalClock.Text = "디지털시계";
            this.TapDigitalClock.UseVisualStyleBackColor = true;
            // 
            // FrmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAlarm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TapAlram;
        private System.Windows.Forms.TabPage TapDigitalClock;
    }
}

