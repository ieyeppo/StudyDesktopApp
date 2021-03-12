
namespace WinCalculatorApp
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
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.BtnNumerology = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnSign = new System.Windows.Forms.Button();
            this.BtnMMinus = new System.Windows.Forms.Button();
            this.BtnMPlus = new System.Windows.Forms.Button();
            this.BtnMR = new System.Windows.Forms.Button();
            this.BtnMC = new System.Windows.Forms.Button();
            this.BtnMS = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnRoot = new System.Windows.Forms.Button();
            this.BtnSqr = new System.Windows.Forms.Button();
            this.BtnRecip = new System.Windows.Forms.Button();
            this.TxtExp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtResult
            // 
            this.TxtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtResult.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtResult.Location = new System.Drawing.Point(10, 45);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(252, 32);
            this.TxtResult.TabIndex = 0;
            this.TxtResult.Text = "0";
            this.TxtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.Color.Plum;
            this.BtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinus.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMinus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMinus.Location = new System.Drawing.Point(202, 271);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(60, 60);
            this.BtnMinus.TabIndex = 8;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.BtnOp_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.HotPink;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn6.Location = new System.Drawing.Point(138, 271);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(60, 60);
            this.Btn6.TabIndex = 7;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.HotPink;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn5.Location = new System.Drawing.Point(74, 271);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(60, 60);
            this.Btn5.TabIndex = 6;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.HotPink;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn4.Location = new System.Drawing.Point(10, 271);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(60, 60);
            this.Btn4.TabIndex = 5;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.Color.Plum;
            this.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlus.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnPlus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPlus.Location = new System.Drawing.Point(202, 333);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(60, 60);
            this.BtnPlus.TabIndex = 12;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.BtnOp_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.HotPink;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn3.Location = new System.Drawing.Point(138, 333);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(60, 60);
            this.Btn3.TabIndex = 11;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.HotPink;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn2.Location = new System.Drawing.Point(74, 333);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(60, 60);
            this.Btn2.TabIndex = 10;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.HotPink;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn1.Location = new System.Drawing.Point(10, 333);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(60, 60);
            this.Btn1.TabIndex = 9;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.BackColor = System.Drawing.Color.Plum;
            this.BtnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResult.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnResult.Location = new System.Drawing.Point(202, 395);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(60, 60);
            this.BtnResult.TabIndex = 16;
            this.BtnResult.Text = "=";
            this.BtnResult.UseVisualStyleBackColor = false;
            this.BtnResult.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnNumerology
            // 
            this.BtnNumerology.BackColor = System.Drawing.Color.Plum;
            this.BtnNumerology.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNumerology.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnNumerology.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNumerology.Location = new System.Drawing.Point(138, 395);
            this.BtnNumerology.Name = "BtnNumerology";
            this.BtnNumerology.Size = new System.Drawing.Size(60, 60);
            this.BtnNumerology.TabIndex = 15;
            this.BtnNumerology.Text = ".";
            this.BtnNumerology.UseVisualStyleBackColor = false;
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.HotPink;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn0.Location = new System.Drawing.Point(74, 395);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(60, 60);
            this.Btn0.TabIndex = 14;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnSign
            // 
            this.BtnSign.BackColor = System.Drawing.Color.Plum;
            this.BtnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSign.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSign.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSign.Location = new System.Drawing.Point(10, 395);
            this.BtnSign.Name = "BtnSign";
            this.BtnSign.Size = new System.Drawing.Size(60, 60);
            this.BtnSign.TabIndex = 13;
            this.BtnSign.Text = "+/-";
            this.BtnSign.UseVisualStyleBackColor = false;
            // 
            // BtnMMinus
            // 
            this.BtnMMinus.BackColor = System.Drawing.Color.Plum;
            this.BtnMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMMinus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMMinus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMMinus.Location = new System.Drawing.Point(162, 83);
            this.BtnMMinus.Name = "BtnMMinus";
            this.BtnMMinus.Size = new System.Drawing.Size(50, 30);
            this.BtnMMinus.TabIndex = 20;
            this.BtnMMinus.Text = "M-";
            this.BtnMMinus.UseVisualStyleBackColor = false;
            // 
            // BtnMPlus
            // 
            this.BtnMPlus.BackColor = System.Drawing.Color.Plum;
            this.BtnMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMPlus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMPlus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMPlus.Location = new System.Drawing.Point(112, 83);
            this.BtnMPlus.Name = "BtnMPlus";
            this.BtnMPlus.Size = new System.Drawing.Size(50, 30);
            this.BtnMPlus.TabIndex = 19;
            this.BtnMPlus.Text = "M+";
            this.BtnMPlus.UseVisualStyleBackColor = false;
            // 
            // BtnMR
            // 
            this.BtnMR.BackColor = System.Drawing.Color.Plum;
            this.BtnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMR.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMR.Location = new System.Drawing.Point(61, 83);
            this.BtnMR.Name = "BtnMR";
            this.BtnMR.Size = new System.Drawing.Size(50, 30);
            this.BtnMR.TabIndex = 18;
            this.BtnMR.Text = "MR";
            this.BtnMR.UseVisualStyleBackColor = false;
            this.BtnMR.Click += new System.EventHandler(this.BtnMR_Click);
            // 
            // BtnMC
            // 
            this.BtnMC.BackColor = System.Drawing.Color.Plum;
            this.BtnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMC.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMC.Location = new System.Drawing.Point(10, 83);
            this.BtnMC.Name = "BtnMC";
            this.BtnMC.Size = new System.Drawing.Size(50, 30);
            this.BtnMC.TabIndex = 17;
            this.BtnMC.Text = "MC";
            this.BtnMC.UseVisualStyleBackColor = false;
            this.BtnMC.Click += new System.EventHandler(this.BtnMC_Click);
            // 
            // BtnMS
            // 
            this.BtnMS.BackColor = System.Drawing.Color.Plum;
            this.BtnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMS.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMS.Location = new System.Drawing.Point(212, 83);
            this.BtnMS.Name = "BtnMS";
            this.BtnMS.Size = new System.Drawing.Size(50, 30);
            this.BtnMS.TabIndex = 21;
            this.BtnMS.Text = "MS";
            this.BtnMS.UseVisualStyleBackColor = false;
            this.BtnMS.Click += new System.EventHandler(this.BtnMS_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.HotPink;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn7.Location = new System.Drawing.Point(10, 209);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(60, 60);
            this.Btn7.TabIndex = 1;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.HotPink;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn8.Location = new System.Drawing.Point(74, 209);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(60, 60);
            this.Btn8.TabIndex = 2;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.HotPink;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn9.Location = new System.Drawing.Point(138, 209);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(60, 60);
            this.Btn9.TabIndex = 3;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.BackColor = System.Drawing.Color.Plum;
            this.BtnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMul.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMul.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMul.Location = new System.Drawing.Point(202, 209);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(60, 60);
            this.BtnMul.TabIndex = 4;
            this.BtnMul.Text = "×";
            this.BtnMul.UseVisualStyleBackColor = false;
            this.BtnMul.Click += new System.EventHandler(this.BtnOp_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.Plum;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDel.Location = new System.Drawing.Point(202, 115);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(60, 30);
            this.BtnDel.TabIndex = 25;
            this.BtnDel.Text = "⌫";
            this.BtnDel.UseVisualStyleBackColor = false;
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.Plum;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnC.Location = new System.Drawing.Point(138, 115);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(60, 30);
            this.BtnC.TabIndex = 24;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.Plum;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCE.Location = new System.Drawing.Point(74, 115);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(60, 30);
            this.BtnCE.TabIndex = 23;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.Plum;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnPercent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPercent.Location = new System.Drawing.Point(10, 115);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(60, 30);
            this.BtnPercent.TabIndex = 22;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = false;
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.Color.Plum;
            this.BtnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiv.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDiv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDiv.Location = new System.Drawing.Point(202, 147);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(60, 60);
            this.BtnDiv.TabIndex = 29;
            this.BtnDiv.Text = "÷";
            this.BtnDiv.UseVisualStyleBackColor = false;
            this.BtnDiv.Click += new System.EventHandler(this.BtnOp_Click);
            // 
            // BtnRoot
            // 
            this.BtnRoot.BackColor = System.Drawing.Color.Plum;
            this.BtnRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoot.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnRoot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRoot.Location = new System.Drawing.Point(138, 147);
            this.BtnRoot.Name = "BtnRoot";
            this.BtnRoot.Size = new System.Drawing.Size(60, 60);
            this.BtnRoot.TabIndex = 28;
            this.BtnRoot.Text = "²√x";
            this.BtnRoot.UseVisualStyleBackColor = false;
            // 
            // BtnSqr
            // 
            this.BtnSqr.BackColor = System.Drawing.Color.Plum;
            this.BtnSqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSqr.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSqr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSqr.Location = new System.Drawing.Point(74, 147);
            this.BtnSqr.Name = "BtnSqr";
            this.BtnSqr.Size = new System.Drawing.Size(60, 60);
            this.BtnSqr.TabIndex = 27;
            this.BtnSqr.Text = " x²";
            this.BtnSqr.UseVisualStyleBackColor = false;
            // 
            // BtnRecip
            // 
            this.BtnRecip.BackColor = System.Drawing.Color.Plum;
            this.BtnRecip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecip.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnRecip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRecip.Location = new System.Drawing.Point(10, 147);
            this.BtnRecip.Name = "BtnRecip";
            this.BtnRecip.Size = new System.Drawing.Size(60, 60);
            this.BtnRecip.TabIndex = 26;
            this.BtnRecip.Text = "1/x";
            this.BtnRecip.UseVisualStyleBackColor = false;
            // 
            // TxtExp
            // 
            this.TxtExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtExp.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtExp.Location = new System.Drawing.Point(10, 7);
            this.TxtExp.Multiline = true;
            this.TxtExp.Name = "TxtExp";
            this.TxtExp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtExp.Size = new System.Drawing.Size(252, 32);
            this.TxtExp.TabIndex = 30;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(274, 461);
            this.Controls.Add(this.TxtExp);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnRoot);
            this.Controls.Add(this.BtnSqr);
            this.Controls.Add(this.BtnRecip);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnMS);
            this.Controls.Add(this.BtnMMinus);
            this.Controls.Add(this.BtnMPlus);
            this.Controls.Add(this.BtnMR);
            this.Controls.Add(this.BtnMC);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.BtnNumerology);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnSign);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.TxtResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "윈도우 계산기";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.Button BtnNumerology;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnSign;
        private System.Windows.Forms.Button BtnMMinus;
        private System.Windows.Forms.Button BtnMPlus;
        private System.Windows.Forms.Button BtnMR;
        private System.Windows.Forms.Button BtnMC;
        private System.Windows.Forms.Button BtnMS;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnRoot;
        private System.Windows.Forms.Button BtnSqr;
        private System.Windows.Forms.Button BtnRecip;
        private System.Windows.Forms.TextBox TxtExp;
    }
}

