
namespace CheckBoxWinApp
{
    partial class FrmMain
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
            this.LblQuestion = new System.Windows.Forms.Label();
            this.ChkApple = new System.Windows.Forms.CheckBox();
            this.ChkStroberry = new System.Windows.Forms.CheckBox();
            this.ChkCherry = new System.Windows.Forms.CheckBox();
            this.ChkBanana = new System.Windows.Forms.CheckBox();
            this.ChkOrange = new System.Windows.Forms.CheckBox();
            this.ChkPear = new System.Windows.Forms.CheckBox();
            this.BtnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.Location = new System.Drawing.Point(22, 26);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(213, 12);
            this.LblQuestion.TabIndex = 0;
            this.LblQuestion.Text = "질문 : 좋아하는 과일을 모두 고르시오.";
            // 
            // ChkApple
            // 
            this.ChkApple.AutoSize = true;
            this.ChkApple.Location = new System.Drawing.Point(24, 63);
            this.ChkApple.Name = "ChkApple";
            this.ChkApple.Size = new System.Drawing.Size(48, 16);
            this.ChkApple.TabIndex = 1;
            this.ChkApple.Text = "사과";
            this.ChkApple.UseVisualStyleBackColor = true;
            // 
            // ChkStroberry
            // 
            this.ChkStroberry.AutoSize = true;
            this.ChkStroberry.Location = new System.Drawing.Point(24, 90);
            this.ChkStroberry.Name = "ChkStroberry";
            this.ChkStroberry.Size = new System.Drawing.Size(48, 16);
            this.ChkStroberry.TabIndex = 2;
            this.ChkStroberry.Text = "딸기";
            this.ChkStroberry.UseVisualStyleBackColor = true;
            // 
            // ChkCherry
            // 
            this.ChkCherry.AutoSize = true;
            this.ChkCherry.Location = new System.Drawing.Point(24, 117);
            this.ChkCherry.Name = "ChkCherry";
            this.ChkCherry.Size = new System.Drawing.Size(48, 16);
            this.ChkCherry.TabIndex = 3;
            this.ChkCherry.Text = "체리";
            this.ChkCherry.UseVisualStyleBackColor = true;
            // 
            // ChkBanana
            // 
            this.ChkBanana.AutoSize = true;
            this.ChkBanana.Location = new System.Drawing.Point(24, 144);
            this.ChkBanana.Name = "ChkBanana";
            this.ChkBanana.Size = new System.Drawing.Size(60, 16);
            this.ChkBanana.TabIndex = 4;
            this.ChkBanana.Text = "바나나";
            this.ChkBanana.UseVisualStyleBackColor = true;
            // 
            // ChkOrange
            // 
            this.ChkOrange.AutoSize = true;
            this.ChkOrange.Location = new System.Drawing.Point(24, 171);
            this.ChkOrange.Name = "ChkOrange";
            this.ChkOrange.Size = new System.Drawing.Size(60, 16);
            this.ChkOrange.TabIndex = 5;
            this.ChkOrange.Text = "오렌지";
            this.ChkOrange.UseVisualStyleBackColor = true;
            // 
            // ChkPear
            // 
            this.ChkPear.AutoSize = true;
            this.ChkPear.Location = new System.Drawing.Point(24, 198);
            this.ChkPear.Name = "ChkPear";
            this.ChkPear.Size = new System.Drawing.Size(36, 16);
            this.ChkPear.TabIndex = 6;
            this.ChkPear.Text = "배";
            this.ChkPear.UseVisualStyleBackColor = true;
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(284, 224);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(100, 28);
            this.BtnResult.TabIndex = 7;
            this.BtnResult.Text = "결과";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 264);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.ChkPear);
            this.Controls.Add(this.ChkOrange);
            this.Controls.Add(this.ChkBanana);
            this.Controls.Add(this.ChkCherry);
            this.Controls.Add(this.ChkStroberry);
            this.Controls.Add(this.ChkApple);
            this.Controls.Add(this.LblQuestion);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.CheckBox ChkApple;
        private System.Windows.Forms.CheckBox ChkStroberry;
        private System.Windows.Forms.CheckBox ChkCherry;
        private System.Windows.Forms.CheckBox ChkBanana;
        private System.Windows.Forms.CheckBox ChkOrange;
        private System.Windows.Forms.CheckBox ChkPear;
        private System.Windows.Forms.Button BtnResult;
    }
}