
namespace LabelTestWinApp
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
            this.btnTxt = new System.Windows.Forms.Button();
            this.LblAutoSize = new System.Windows.Forms.Label();
            this.LblManualSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(13, 13);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(110, 40);
            this.btnTxt.TabIndex = 0;
            this.btnTxt.Text = "텍스트입력";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // LblAutoSize
            // 
            this.LblAutoSize.AutoSize = true;
            this.LblAutoSize.Location = new System.Drawing.Point(14, 67);
            this.LblAutoSize.Name = "LblAutoSize";
            this.LblAutoSize.Size = new System.Drawing.Size(72, 12);
            this.LblAutoSize.TabIndex = 1;
            this.LblAutoSize.Text = "LblAutoSize";
            // 
            // LblManualSize
            // 
            this.LblManualSize.Location = new System.Drawing.Point(14, 91);
            this.LblManualSize.MaximumSize = new System.Drawing.Size(300, 200);
            this.LblManualSize.Name = "LblManualSize";
            this.LblManualSize.Size = new System.Drawing.Size(300, 200);
            this.LblManualSize.TabIndex = 2;
            this.LblManualSize.Text = "LblManualSize";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.LblManualSize);
            this.Controls.Add(this.LblAutoSize);
            this.Controls.Add(this.btnTxt);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Label Control App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Label LblAutoSize;
        private System.Windows.Forms.Label LblManualSize;
    }
}

