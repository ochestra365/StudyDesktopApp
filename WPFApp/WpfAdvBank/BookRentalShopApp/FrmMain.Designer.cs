﻿
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
            this.MnuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDivCode = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMember = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuRental = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuManagement,
            this.MnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuManagement
            // 
            this.MnuManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDivCode,
            this.MnuMember,
            this.MnuBooks,
            this.toolStripMenuItem2,
            this.MnuRental});
            this.MnuManagement.Name = "MnuManagement";
            this.MnuManagement.Size = new System.Drawing.Size(62, 20);
            this.MnuManagement.Text = "관리(&M)";
            // 
            // MnuDivCode
            // 
            this.MnuDivCode.Name = "MnuDivCode";
            this.MnuDivCode.Size = new System.Drawing.Size(180, 22);
            this.MnuDivCode.Text = "구분코드(&C)";
            this.MnuDivCode.Click += new System.EventHandler(this.MnuDivCode_Click);
            // 
            // MnuMember
            // 
            this.MnuMember.Name = "MnuMember";
            this.MnuMember.Size = new System.Drawing.Size(180, 22);
            this.MnuMember.Text = "회원(&P)";
            this.MnuMember.Click += new System.EventHandler(this.MnuMember_Click);
            // 
            // MnuBooks
            // 
            this.MnuBooks.Name = "MnuBooks";
            this.MnuBooks.Size = new System.Drawing.Size(180, 22);
            this.MnuBooks.Text = "도서(&B)";
            this.MnuBooks.Click += new System.EventHandler(this.MnuBooks_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuRental
            // 
            this.MnuRental.Name = "MnuRental";
            this.MnuRental.Size = new System.Drawing.Size(180, 22);
            this.MnuRental.Text = "대여(&R)";
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(58, 20);
            this.MnuExit.Text = "종료(&X)";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "성철이네 책대여점";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuManagement;
        private System.Windows.Forms.ToolStripMenuItem MnuDivCode;
        private System.Windows.Forms.ToolStripMenuItem MnuMember;
        private System.Windows.Forms.ToolStripMenuItem MnuBooks;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MnuRental;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
    }
}

