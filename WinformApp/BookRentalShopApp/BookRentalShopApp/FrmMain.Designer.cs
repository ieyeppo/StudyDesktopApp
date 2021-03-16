
namespace BookRentalShopApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도서관리BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.대어관리RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MntEXit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리MToolStripMenuItem,
            this.MntEXit});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리MToolStripMenuItem
            // 
            this.관리MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원관리ToolStripMenuItem,
            this.회원관리MToolStripMenuItem,
            this.도서관리BToolStripMenuItem,
            this.대어관리RToolStripMenuItem});
            this.관리MToolStripMenuItem.Name = "관리MToolStripMenuItem";
            this.관리MToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.관리MToolStripMenuItem.Text = "관리(&M)";
            // 
            // 회원관리ToolStripMenuItem
            // 
            this.회원관리ToolStripMenuItem.Name = "회원관리ToolStripMenuItem";
            this.회원관리ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.회원관리ToolStripMenuItem.Text = "구분코드(&C)";
            // 
            // 회원관리MToolStripMenuItem
            // 
            this.회원관리MToolStripMenuItem.Name = "회원관리MToolStripMenuItem";
            this.회원관리MToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.회원관리MToolStripMenuItem.Text = "회원관리(&M)";
            // 
            // 도서관리BToolStripMenuItem
            // 
            this.도서관리BToolStripMenuItem.Name = "도서관리BToolStripMenuItem";
            this.도서관리BToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.도서관리BToolStripMenuItem.Text = "도서관리(&B)";
            // 
            // 대어관리RToolStripMenuItem
            // 
            this.대어관리RToolStripMenuItem.Name = "대어관리RToolStripMenuItem";
            this.대어관리RToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.대어관리RToolStripMenuItem.Text = "대여관리(&R)";
            // 
            // MntEXit
            // 
            this.MntEXit.Name = "MntEXit";
            this.MntEXit.Size = new System.Drawing.Size(58, 20);
            this.MntEXit.Text = "종료(&X)";
            this.MntEXit.Click += new System.EventHandler(this.MntEXit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "로그인 : ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "책 대여점 프로그램";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리MToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 회원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원관리MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도서관리BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 대어관리RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MntEXit;
    }
}

