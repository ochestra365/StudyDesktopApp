
namespace RadioWinApp
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
            this.BtnResult = new System.Windows.Forms.Button();
            this.RgbKorea = new System.Windows.Forms.RadioButton();
            this.RdbChina = new System.Windows.Forms.RadioButton();
            this.RgbJapan = new System.Windows.Forms.RadioButton();
            this.RgbOthers = new System.Windows.Forms.RadioButton();
            this.RgbMale = new System.Windows.Forms.RadioButton();
            this.RgbFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(153, 115);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(65, 28);
            this.BtnResult.TabIndex = 0;
            this.BtnResult.Text = "결과";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // RgbKorea
            // 
            this.RgbKorea.AutoSize = true;
            this.RgbKorea.Location = new System.Drawing.Point(14, 20);
            this.RgbKorea.Name = "RgbKorea";
            this.RgbKorea.Size = new System.Drawing.Size(51, 16);
            this.RgbKorea.TabIndex = 1;
            this.RgbKorea.TabStop = true;
            this.RgbKorea.Text = " 한국";
            this.RgbKorea.UseVisualStyleBackColor = true;
            // 
            // RdbChina
            // 
            this.RdbChina.AutoSize = true;
            this.RdbChina.Location = new System.Drawing.Point(14, 42);
            this.RdbChina.Name = "RdbChina";
            this.RdbChina.Size = new System.Drawing.Size(47, 16);
            this.RdbChina.TabIndex = 2;
            this.RdbChina.TabStop = true;
            this.RdbChina.Text = "중국";
            this.RdbChina.UseVisualStyleBackColor = true;
            // 
            // RgbJapan
            // 
            this.RgbJapan.AutoSize = true;
            this.RgbJapan.Location = new System.Drawing.Point(14, 64);
            this.RgbJapan.Name = "RgbJapan";
            this.RgbJapan.Size = new System.Drawing.Size(47, 16);
            this.RgbJapan.TabIndex = 3;
            this.RgbJapan.TabStop = true;
            this.RgbJapan.Text = "일본";
            this.RgbJapan.UseVisualStyleBackColor = true;
            // 
            // RgbOthers
            // 
            this.RgbOthers.AutoSize = true;
            this.RgbOthers.Location = new System.Drawing.Point(14, 86);
            this.RgbOthers.Name = "RgbOthers";
            this.RgbOthers.Size = new System.Drawing.Size(47, 16);
            this.RgbOthers.TabIndex = 4;
            this.RgbOthers.TabStop = true;
            this.RgbOthers.Text = "기타";
            this.RgbOthers.UseVisualStyleBackColor = true;
            // 
            // RgbMale
            // 
            this.RgbMale.AutoSize = true;
            this.RgbMale.Location = new System.Drawing.Point(8, 15);
            this.RgbMale.Name = "RgbMale";
            this.RgbMale.Size = new System.Drawing.Size(47, 16);
            this.RgbMale.TabIndex = 5;
            this.RgbMale.TabStop = true;
            this.RgbMale.Text = "남자";
            this.RgbMale.UseVisualStyleBackColor = true;
            // 
            // RgbFemale
            // 
            this.RgbFemale.AutoSize = true;
            this.RgbFemale.Location = new System.Drawing.Point(61, 15);
            this.RgbFemale.Name = "RgbFemale";
            this.RgbFemale.Size = new System.Drawing.Size(47, 16);
            this.RgbFemale.TabIndex = 6;
            this.RgbFemale.TabStop = true;
            this.RgbFemale.Text = "여자";
            this.RgbFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RgbOthers);
            this.groupBox1.Controls.Add(this.RgbJapan);
            this.groupBox1.Controls.Add(this.RdbChina);
            this.groupBox1.Controls.Add(this.RgbKorea);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(79, 115);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "나라";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RgbMale);
            this.groupBox2.Controls.Add(this.RgbFemale);
            this.groupBox2.Location = new System.Drawing.Point(103, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 43);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(237, 152);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnResult);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadioWinApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.RadioButton RgbKorea;
        private System.Windows.Forms.RadioButton RdbChina;
        private System.Windows.Forms.RadioButton RgbJapan;
        private System.Windows.Forms.RadioButton RgbOthers;
        private System.Windows.Forms.RadioButton RgbMale;
        private System.Windows.Forms.RadioButton RgbFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

