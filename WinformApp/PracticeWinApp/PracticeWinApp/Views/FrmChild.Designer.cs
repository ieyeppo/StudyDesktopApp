﻿
namespace PracticeWinApp.Views
{
    partial class FrmChild
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
            this.btnQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(61, 13);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(156, 36);
            this.btnQuestion.TabIndex = 0;
            this.btnQuestion.Text = "질문";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // FrmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.btnQuestion);
            this.Name = "FrmChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "자식 폼";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuestion;
    }
}