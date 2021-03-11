﻿
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
            this.components = new System.ComponentModel.Container();
            this.TabClock = new System.Windows.Forms.TabControl();
            this.TapSetAlarm = new System.Windows.Forms.TabPage();
            this.BtnRelease = new System.Windows.Forms.Button();
            this.BtnSet = new System.Windows.Forms.Button();
            this.DtpAlarmTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DtpAlarmDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TapDigitalClock = new System.Windows.Forms.TabPage();
            this.LblAlarm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.TabClock.SuspendLayout();
            this.TapSetAlarm.SuspendLayout();
            this.TapDigitalClock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabClock
            // 
            this.TabClock.Controls.Add(this.TapSetAlarm);
            this.TabClock.Controls.Add(this.TapDigitalClock);
            this.TabClock.Location = new System.Drawing.Point(12, 12);
            this.TabClock.Name = "TabClock";
            this.TabClock.SelectedIndex = 0;
            this.TabClock.Size = new System.Drawing.Size(319, 357);
            this.TabClock.TabIndex = 0;
            // 
            // TapSetAlarm
            // 
            this.TapSetAlarm.Controls.Add(this.BtnRelease);
            this.TapSetAlarm.Controls.Add(this.BtnSet);
            this.TapSetAlarm.Controls.Add(this.DtpAlarmTime);
            this.TapSetAlarm.Controls.Add(this.dateTimePicker1);
            this.TapSetAlarm.Controls.Add(this.DtpAlarmDate);
            this.TapSetAlarm.Controls.Add(this.label1);
            this.TapSetAlarm.Location = new System.Drawing.Point(4, 22);
            this.TapSetAlarm.Name = "TapSetAlarm";
            this.TapSetAlarm.Padding = new System.Windows.Forms.Padding(3);
            this.TapSetAlarm.Size = new System.Drawing.Size(311, 331);
            this.TapSetAlarm.TabIndex = 0;
            this.TapSetAlarm.Text = "알람설정";
            this.TapSetAlarm.UseVisualStyleBackColor = true;
            // 
            // BtnRelease
            // 
            this.BtnRelease.Location = new System.Drawing.Point(204, 265);
            this.BtnRelease.Name = "BtnRelease";
            this.BtnRelease.Size = new System.Drawing.Size(75, 23);
            this.BtnRelease.TabIndex = 5;
            this.BtnRelease.Text = "해제";
            this.BtnRelease.UseVisualStyleBackColor = true;
            this.BtnRelease.Click += new System.EventHandler(this.BtnRelease_Click);
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(123, 265);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(75, 23);
            this.BtnSet.TabIndex = 4;
            this.BtnSet.Text = "설정";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // DtpAlarmTime
            // 
            this.DtpAlarmTime.CustomFormat = "hh:mm:ss";
            this.DtpAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpAlarmTime.Location = new System.Drawing.Point(31, 108);
            this.DtpAlarmTime.Name = "DtpAlarmTime";
            this.DtpAlarmTime.Size = new System.Drawing.Size(200, 21);
            this.DtpAlarmTime.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // DtpAlarmDate
            // 
            this.DtpAlarmDate.AutoSize = true;
            this.DtpAlarmDate.Location = new System.Drawing.Point(29, 93);
            this.DtpAlarmDate.Name = "DtpAlarmDate";
            this.DtpAlarmDate.Size = new System.Drawing.Size(57, 12);
            this.DtpAlarmDate.TabIndex = 1;
            this.DtpAlarmDate.Text = "시간 설정";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "날짜 설정";
            // 
            // TapDigitalClock
            // 
            this.TapDigitalClock.Controls.Add(this.LblAlarm);
            this.TapDigitalClock.Controls.Add(this.label3);
            this.TapDigitalClock.Controls.Add(this.groupBox1);
            this.TapDigitalClock.Location = new System.Drawing.Point(4, 22);
            this.TapDigitalClock.Name = "TapDigitalClock";
            this.TapDigitalClock.Padding = new System.Windows.Forms.Padding(3);
            this.TapDigitalClock.Size = new System.Drawing.Size(311, 331);
            this.TapDigitalClock.TabIndex = 1;
            this.TapDigitalClock.Text = "디지털시계";
            this.TapDigitalClock.UseVisualStyleBackColor = true;
            // 
            // LblAlarm
            // 
            this.LblAlarm.AutoSize = true;
            this.LblAlarm.Location = new System.Drawing.Point(21, 70);
            this.LblAlarm.Name = "LblAlarm";
            this.LblAlarm.Size = new System.Drawing.Size(50, 12);
            this.LblAlarm.TabIndex = 1;
            this.LblAlarm.Text = "Alarm : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "알람 설정";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblTime);
            this.groupBox1.Controls.Add(this.LblDate);
            this.groupBox1.Location = new System.Drawing.Point(23, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현재시간";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("나눔고딕코딩", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblTime.Location = new System.Drawing.Point(17, 91);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(79, 32);
            this.LblTime.TabIndex = 4;
            this.LblTime.Text = "Time";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(17, 34);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(30, 12);
            this.LblDate.TabIndex = 3;
            this.LblDate.Text = "Date";
            // 
            // FrmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 381);
            this.Controls.Add(this.TabClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmAlarm";
            this.Text = "TabPage 컬렉션편집기";
            this.Load += new System.EventHandler(this.FrmAlarm_Load);
            this.TabClock.ResumeLayout(false);
            this.TapSetAlarm.ResumeLayout(false);
            this.TapSetAlarm.PerformLayout();
            this.TapDigitalClock.ResumeLayout(false);
            this.TapDigitalClock.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabClock;
        private System.Windows.Forms.TabPage TapSetAlarm;
        private System.Windows.Forms.TabPage TapDigitalClock;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DtpAlarmDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRelease;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.DateTimePicker DtpAlarmTime;
        private System.Windows.Forms.Label LblAlarm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Timer MyTimer;
    }
}

