
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
            this.BtnMC = new System.Windows.Forms.Button();
            this.BtnCe = new System.Windows.Forms.Button();
            this.BtnMR = new System.Windows.Forms.Button();
            this.BtnMplus = new System.Windows.Forms.Button();
            this.BtnMminus = new System.Windows.Forms.Button();
            this.BtnMs = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnSqrt = new System.Windows.Forms.Button();
            this.BtnSqr = new System.Windows.Forms.Button();
            this.BtnReclp = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnMultiple = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnSign = new System.Windows.Forms.Button();
            this.TxtExp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtResult
            // 
            this.TxtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtResult.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtResult.Location = new System.Drawing.Point(3, 55);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(308, 32);
            this.TxtResult.TabIndex = 0;
            this.TxtResult.Text = "0";
            this.TxtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnMC
            // 
            this.BtnMC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMC.FlatAppearance.BorderSize = 0;
            this.BtnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMC.Location = new System.Drawing.Point(12, 93);
            this.BtnMC.Name = "BtnMC";
            this.BtnMC.Size = new System.Drawing.Size(56, 35);
            this.BtnMC.TabIndex = 1;
            this.BtnMC.Text = "MC";
            this.BtnMC.UseVisualStyleBackColor = true;
            this.BtnMC.Click += new System.EventHandler(this.BtnMC_Click);
            // 
            // BtnCe
            // 
            this.BtnCe.BackColor = System.Drawing.Color.Silver;
            this.BtnCe.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnCe.FlatAppearance.BorderSize = 0;
            this.BtnCe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCe.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCe.Location = new System.Drawing.Point(24, 175);
            this.BtnCe.Name = "BtnCe";
            this.BtnCe.Size = new System.Drawing.Size(45, 38);
            this.BtnCe.TabIndex = 2;
            this.BtnCe.Text = "CE";
            this.BtnCe.UseVisualStyleBackColor = false;
            // 
            // BtnMR
            // 
            this.BtnMR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMR.FlatAppearance.BorderSize = 0;
            this.BtnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMR.Location = new System.Drawing.Point(74, 93);
            this.BtnMR.Name = "BtnMR";
            this.BtnMR.Size = new System.Drawing.Size(56, 35);
            this.BtnMR.TabIndex = 1;
            this.BtnMR.Text = "MR";
            this.BtnMR.UseVisualStyleBackColor = true;
            this.BtnMR.Click += new System.EventHandler(this.BtnMR_Click);
            // 
            // BtnMplus
            // 
            this.BtnMplus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMplus.FlatAppearance.BorderSize = 0;
            this.BtnMplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMplus.Location = new System.Drawing.Point(136, 93);
            this.BtnMplus.Name = "BtnMplus";
            this.BtnMplus.Size = new System.Drawing.Size(56, 35);
            this.BtnMplus.TabIndex = 1;
            this.BtnMplus.Text = "M+";
            this.BtnMplus.UseVisualStyleBackColor = true;
            this.BtnMplus.Click += new System.EventHandler(this.BtnMplus_Click);
            // 
            // BtnMminus
            // 
            this.BtnMminus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMminus.FlatAppearance.BorderSize = 0;
            this.BtnMminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMminus.Location = new System.Drawing.Point(198, 93);
            this.BtnMminus.Name = "BtnMminus";
            this.BtnMminus.Size = new System.Drawing.Size(56, 35);
            this.BtnMminus.TabIndex = 1;
            this.BtnMminus.Text = "M-";
            this.BtnMminus.UseVisualStyleBackColor = true;
            this.BtnMminus.Click += new System.EventHandler(this.BtnMminus_Click);
            // 
            // BtnMs
            // 
            this.BtnMs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMs.FlatAppearance.BorderSize = 0;
            this.BtnMs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMs.Location = new System.Drawing.Point(260, 93);
            this.BtnMs.Name = "BtnMs";
            this.BtnMs.Size = new System.Drawing.Size(56, 35);
            this.BtnMs.TabIndex = 1;
            this.BtnMs.Text = "MS";
            this.BtnMs.UseVisualStyleBackColor = true;
            this.BtnMs.Click += new System.EventHandler(this.BtnMs_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnPercent.FlatAppearance.BorderSize = 0;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnPercent.Location = new System.Drawing.Point(12, 134);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(56, 35);
            this.BtnPercent.TabIndex = 1;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = true;
            // 
            // BtnSqrt
            // 
            this.BtnSqrt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSqrt.FlatAppearance.BorderSize = 0;
            this.BtnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSqrt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSqrt.Location = new System.Drawing.Point(74, 134);
            this.BtnSqrt.Name = "BtnSqrt";
            this.BtnSqrt.Size = new System.Drawing.Size(56, 35);
            this.BtnSqrt.TabIndex = 1;
            this.BtnSqrt.Text = "√";
            this.BtnSqrt.UseVisualStyleBackColor = true;
            // 
            // BtnSqr
            // 
            this.BtnSqr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSqr.FlatAppearance.BorderSize = 0;
            this.BtnSqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSqr.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSqr.Location = new System.Drawing.Point(136, 134);
            this.BtnSqr.Name = "BtnSqr";
            this.BtnSqr.Size = new System.Drawing.Size(56, 35);
            this.BtnSqr.TabIndex = 1;
            this.BtnSqr.Text = "^2";
            this.BtnSqr.UseVisualStyleBackColor = true;
            // 
            // BtnReclp
            // 
            this.BtnReclp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnReclp.FlatAppearance.BorderSize = 0;
            this.BtnReclp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReclp.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnReclp.Location = new System.Drawing.Point(198, 134);
            this.BtnReclp.Name = "BtnReclp";
            this.BtnReclp.Size = new System.Drawing.Size(56, 35);
            this.BtnReclp.TabIndex = 1;
            this.BtnReclp.Text = "^(-1)";
            this.BtnReclp.UseVisualStyleBackColor = true;
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.Silver;
            this.BtnC.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnC.Location = new System.Drawing.Point(77, 175);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(45, 38);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.Silver;
            this.BtnDel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnDel.FlatAppearance.BorderSize = 0;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDel.Location = new System.Drawing.Point(130, 175);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(45, 38);
            this.BtnDel.TabIndex = 4;
            this.BtnDel.Text = "⌫";
            this.BtnDel.UseVisualStyleBackColor = false;
            // 
            // BtnDivide
            // 
            this.BtnDivide.BackColor = System.Drawing.Color.Silver;
            this.BtnDivide.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnDivide.FlatAppearance.BorderSize = 0;
            this.BtnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivide.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDivide.Location = new System.Drawing.Point(183, 175);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(45, 38);
            this.BtnDivide.TabIndex = 5;
            this.BtnDivide.Text = "÷";
            this.BtnDivide.UseVisualStyleBackColor = false;
            this.BtnDivide.Click += new System.EventHandler(this.BtnOp_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.Silver;
            this.Btn7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn7.Location = new System.Drawing.Point(24, 219);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(45, 38);
            this.Btn7.TabIndex = 2;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.Silver;
            this.Btn8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn8.Location = new System.Drawing.Point(77, 219);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(45, 38);
            this.Btn8.TabIndex = 3;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.Silver;
            this.Btn9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn9.Location = new System.Drawing.Point(130, 219);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(45, 38);
            this.Btn9.TabIndex = 4;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnMultiple
            // 
            this.BtnMultiple.BackColor = System.Drawing.Color.Silver;
            this.BtnMultiple.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnMultiple.FlatAppearance.BorderSize = 0;
            this.BtnMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiple.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMultiple.Location = new System.Drawing.Point(183, 219);
            this.BtnMultiple.Name = "BtnMultiple";
            this.BtnMultiple.Size = new System.Drawing.Size(45, 38);
            this.BtnMultiple.TabIndex = 5;
            this.BtnMultiple.Text = "x";
            this.BtnMultiple.UseVisualStyleBackColor = false;
            this.BtnMultiple.Click += new System.EventHandler(this.BtnOp_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.Silver;
            this.Btn4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn4.Location = new System.Drawing.Point(24, 263);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(45, 38);
            this.Btn4.TabIndex = 2;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.Silver;
            this.Btn5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn5.Location = new System.Drawing.Point(77, 263);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(45, 38);
            this.Btn5.TabIndex = 3;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.Silver;
            this.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn1.Location = new System.Drawing.Point(24, 307);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(45, 38);
            this.Btn1.TabIndex = 2;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.Silver;
            this.Btn6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn6.Location = new System.Drawing.Point(130, 263);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(45, 38);
            this.Btn6.TabIndex = 4;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.Silver;
            this.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn2.Location = new System.Drawing.Point(77, 307);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(45, 38);
            this.Btn2.TabIndex = 3;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.Color.Silver;
            this.BtnMinus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnMinus.FlatAppearance.BorderSize = 0;
            this.BtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMinus.Location = new System.Drawing.Point(183, 263);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(45, 38);
            this.BtnMinus.TabIndex = 5;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.BtnOp_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.Silver;
            this.Btn3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn3.Location = new System.Drawing.Point(130, 307);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(45, 38);
            this.Btn3.TabIndex = 4;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.Color.Silver;
            this.BtnPlus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnPlus.FlatAppearance.BorderSize = 0;
            this.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnPlus.Location = new System.Drawing.Point(183, 307);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(45, 38);
            this.BtnPlus.TabIndex = 5;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.BtnOp_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.BackColor = System.Drawing.Color.Silver;
            this.BtnEqual.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnEqual.FlatAppearance.BorderSize = 0;
            this.BtnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEqual.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnEqual.Location = new System.Drawing.Point(183, 351);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(45, 38);
            this.BtnEqual.TabIndex = 9;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.BackColor = System.Drawing.Color.Silver;
            this.BtnDot.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnDot.FlatAppearance.BorderSize = 0;
            this.BtnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDot.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDot.Location = new System.Drawing.Point(130, 351);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(45, 38);
            this.BtnDot.TabIndex = 8;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = false;
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.Silver;
            this.Btn0.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn0.Location = new System.Drawing.Point(77, 351);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(45, 38);
            this.Btn0.TabIndex = 7;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnSign
            // 
            this.BtnSign.BackColor = System.Drawing.Color.Silver;
            this.BtnSign.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnSign.FlatAppearance.BorderSize = 0;
            this.BtnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSign.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSign.Location = new System.Drawing.Point(24, 351);
            this.BtnSign.Name = "BtnSign";
            this.BtnSign.Size = new System.Drawing.Size(45, 38);
            this.BtnSign.TabIndex = 6;
            this.BtnSign.Text = "±";
            this.BtnSign.UseVisualStyleBackColor = false;
            // 
            // TxtExp
            // 
            this.TxtExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtExp.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtExp.Location = new System.Drawing.Point(3, 1);
            this.TxtExp.Name = "TxtExp";
            this.TxtExp.Size = new System.Drawing.Size(308, 20);
            this.TxtExp.TabIndex = 0;
            this.TxtExp.Text = "0";
            this.TxtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 395);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnSign);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.BtnMultiple);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCe);
            this.Controls.Add(this.BtnMs);
            this.Controls.Add(this.BtnMminus);
            this.Controls.Add(this.BtnMplus);
            this.Controls.Add(this.BtnMR);
            this.Controls.Add(this.BtnReclp);
            this.Controls.Add(this.BtnSqr);
            this.Controls.Add(this.BtnSqrt);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnMC);
            this.Controls.Add(this.TxtExp);
            this.Controls.Add(this.TxtResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "윈도우 계산기";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button BtnMC;
        private System.Windows.Forms.Button BtnCe;
        private System.Windows.Forms.Button BtnMR;
        private System.Windows.Forms.Button BtnMplus;
        private System.Windows.Forms.Button BtnMminus;
        private System.Windows.Forms.Button BtnMs;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button BtnSqrt;
        private System.Windows.Forms.Button BtnSqr;
        private System.Windows.Forms.Button BtnReclp;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnMultiple;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnSign;
        private System.Windows.Forms.TextBox TxtExp;
    }
}

