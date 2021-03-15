﻿
namespace WinChartApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChpScore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnRegen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChpScore)).BeginInit();
            this.SuspendLayout();
            // 
            // ChpScore
            // 
            chartArea1.Name = "ChartArea1";
            this.ChpScore.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChpScore.Legends.Add(legend1);
            this.ChpScore.Location = new System.Drawing.Point(12, 12);
            this.ChpScore.Name = "ChpScore";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Score";
            this.ChpScore.Series.Add(series1);
            this.ChpScore.Size = new System.Drawing.Size(364, 300);
            this.ChpScore.TabIndex = 0;
            this.ChpScore.Text = "chart1";
            // 
            // BtnRegen
            // 
            this.BtnRegen.Location = new System.Drawing.Point(282, 318);
            this.BtnRegen.Name = "BtnRegen";
            this.BtnRegen.Size = new System.Drawing.Size(94, 23);
            this.BtnRegen.TabIndex = 1;
            this.BtnRegen.Text = "다시 그리기";
            this.BtnRegen.UseVisualStyleBackColor = true;
            this.BtnRegen.Click += new System.EventHandler(this.BtnRegen_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 353);
            this.Controls.Add(this.BtnRegen);
            this.Controls.Add(this.ChpScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using Chart Control";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChpScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChpScore;
        private System.Windows.Forms.Button BtnRegen;
    }
}
