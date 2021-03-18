
namespace BookRentalShopApp
{
    partial class FrmRental
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
            this.GrbDetail = new System.Windows.Forms.GroupBox();
            this.DtpReleaseDate = new MetroFramework.Controls.MetroDateTime();
            this.CboDivision = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TxtReleaseDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.TxtDescriptions = new MetroFramework.Controls.MetroTextBox();
            this.TxtPrice = new MetroFramework.Controls.MetroTextBox();
            this.TxtISBN = new MetroFramework.Controls.MetroTextBox();
            this.Cbobook = new MetroFramework.Controls.MetroTextBox();
            this.TxtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.GrbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbDetail
            // 
            this.GrbDetail.Controls.Add(this.DtpReleaseDate);
            this.GrbDetail.Controls.Add(this.CboDivision);
            this.GrbDetail.Controls.Add(this.metroLabel8);
            this.GrbDetail.Controls.Add(this.metroLabel7);
            this.GrbDetail.Controls.Add(this.metroLabel6);
            this.GrbDetail.Controls.Add(this.TxtReleaseDate);
            this.GrbDetail.Controls.Add(this.metroLabel3);
            this.GrbDetail.Controls.Add(this.metroLabel4);
            this.GrbDetail.Controls.Add(this.BtnSave);
            this.GrbDetail.Controls.Add(this.BtnNew);
            this.GrbDetail.Controls.Add(this.BtnDelete);
            this.GrbDetail.Controls.Add(this.TxtDescriptions);
            this.GrbDetail.Controls.Add(this.TxtPrice);
            this.GrbDetail.Controls.Add(this.TxtISBN);
            this.GrbDetail.Controls.Add(this.Cbobook);
            this.GrbDetail.Controls.Add(this.TxtAuthor);
            this.GrbDetail.Controls.Add(this.TxtIdx);
            this.GrbDetail.Controls.Add(this.metroLabel2);
            this.GrbDetail.Controls.Add(this.metroLabel1);
            this.GrbDetail.Location = new System.Drawing.Point(422, 63);
            this.GrbDetail.Name = "GrbDetail";
            this.GrbDetail.Size = new System.Drawing.Size(355, 364);
            this.GrbDetail.TabIndex = 0;
            this.GrbDetail.TabStop = false;
            this.GrbDetail.Text = "상세";
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.Location = new System.Drawing.Point(86, 147);
            this.DtpReleaseDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(177, 29);
            this.DtpReleaseDate.TabIndex = 5;
            // 
            // CboDivision
            // 
            this.CboDivision.FormattingEnabled = true;
            this.CboDivision.ItemHeight = 23;
            this.CboDivision.Location = new System.Drawing.Point(87, 80);
            this.CboDivision.Name = "CboDivision";
            this.CboDivision.PromptText = "장르";
            this.CboDivision.Size = new System.Drawing.Size(80, 29);
            this.CboDivision.TabIndex = 3;
            this.CboDivision.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(33, 261);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "설명 : ";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 227);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(58, 19);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "아이디 :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(33, 193);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "ISBN : ";
            // 
            // TxtReleaseDate
            // 
            this.TxtReleaseDate.AutoSize = true;
            this.TxtReleaseDate.Location = new System.Drawing.Point(19, 159);
            this.TxtReleaseDate.Name = "TxtReleaseDate";
            this.TxtReleaseDate.Size = new System.Drawing.Size(62, 19);
            this.TxtReleaseDate.TabIndex = 7;
            this.TxtReleaseDate.Text = "출판일 : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "도서명 :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(37, 91);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "장르 :";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(274, 335);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(192, 335);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 10;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(110, 335);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtDescriptions
            // 
            // 
            // 
            // 
            this.TxtDescriptions.CustomButton.Image = null;
            this.TxtDescriptions.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.TxtDescriptions.CustomButton.Name = "";
            this.TxtDescriptions.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.TxtDescriptions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDescriptions.CustomButton.TabIndex = 1;
            this.TxtDescriptions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDescriptions.CustomButton.UseSelectable = true;
            this.TxtDescriptions.CustomButton.Visible = false;
            this.TxtDescriptions.Lines = new string[0];
            this.TxtDescriptions.Location = new System.Drawing.Point(87, 252);
            this.TxtDescriptions.MaxLength = 32767;
            this.TxtDescriptions.Multiline = true;
            this.TxtDescriptions.Name = "TxtDescriptions";
            this.TxtDescriptions.PasswordChar = '\0';
            this.TxtDescriptions.PromptText = "설명";
            this.TxtDescriptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescriptions.SelectedText = "";
            this.TxtDescriptions.SelectionLength = 0;
            this.TxtDescriptions.SelectionStart = 0;
            this.TxtDescriptions.ShortcutsEnabled = true;
            this.TxtDescriptions.Size = new System.Drawing.Size(262, 77);
            this.TxtDescriptions.TabIndex = 8;
            this.TxtDescriptions.UseSelectable = true;
            this.TxtDescriptions.WaterMark = "설명";
            this.TxtDescriptions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDescriptions.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPrice
            // 
            // 
            // 
            // 
            this.TxtPrice.CustomButton.Image = null;
            this.TxtPrice.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.TxtPrice.CustomButton.Name = "";
            this.TxtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPrice.CustomButton.TabIndex = 1;
            this.TxtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPrice.CustomButton.UseSelectable = true;
            this.TxtPrice.CustomButton.Visible = false;
            this.TxtPrice.Lines = new string[0];
            this.TxtPrice.Location = new System.Drawing.Point(86, 218);
            this.TxtPrice.MaxLength = 32767;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PasswordChar = '\0';
            this.TxtPrice.PromptText = "Price";
            this.TxtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPrice.SelectedText = "";
            this.TxtPrice.SelectionLength = 0;
            this.TxtPrice.SelectionStart = 0;
            this.TxtPrice.ShortcutsEnabled = true;
            this.TxtPrice.Size = new System.Drawing.Size(176, 23);
            this.TxtPrice.TabIndex = 7;
            this.TxtPrice.UseSelectable = true;
            this.TxtPrice.WaterMark = "Price";
            this.TxtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPrice.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtISBN
            // 
            // 
            // 
            // 
            this.TxtISBN.CustomButton.Image = null;
            this.TxtISBN.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.TxtISBN.CustomButton.Name = "";
            this.TxtISBN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtISBN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtISBN.CustomButton.TabIndex = 1;
            this.TxtISBN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtISBN.CustomButton.UseSelectable = true;
            this.TxtISBN.CustomButton.Visible = false;
            this.TxtISBN.Lines = new string[0];
            this.TxtISBN.Location = new System.Drawing.Point(87, 184);
            this.TxtISBN.MaxLength = 32767;
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.PasswordChar = '\0';
            this.TxtISBN.PromptText = "ISBN";
            this.TxtISBN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtISBN.SelectedText = "";
            this.TxtISBN.SelectionLength = 0;
            this.TxtISBN.SelectionStart = 0;
            this.TxtISBN.ShortcutsEnabled = true;
            this.TxtISBN.Size = new System.Drawing.Size(176, 23);
            this.TxtISBN.TabIndex = 6;
            this.TxtISBN.UseSelectable = true;
            this.TxtISBN.WaterMark = "ISBN";
            this.TxtISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtISBN.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Cbobook
            // 
            // 
            // 
            // 
            this.Cbobook.CustomButton.Image = null;
            this.Cbobook.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.Cbobook.CustomButton.Name = "";
            this.Cbobook.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Cbobook.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Cbobook.CustomButton.TabIndex = 1;
            this.Cbobook.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Cbobook.CustomButton.UseSelectable = true;
            this.Cbobook.CustomButton.Visible = false;
            this.Cbobook.Lines = new string[0];
            this.Cbobook.Location = new System.Drawing.Point(86, 116);
            this.Cbobook.MaxLength = 32767;
            this.Cbobook.Name = "Cbobook";
            this.Cbobook.PasswordChar = '\0';
            this.Cbobook.PromptText = "도서명";
            this.Cbobook.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Cbobook.SelectedText = "";
            this.Cbobook.SelectionLength = 0;
            this.Cbobook.SelectionStart = 0;
            this.Cbobook.ShortcutsEnabled = true;
            this.Cbobook.Size = new System.Drawing.Size(176, 23);
            this.Cbobook.TabIndex = 4;
            this.Cbobook.UseSelectable = true;
            this.Cbobook.WaterMark = "도서명";
            this.Cbobook.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Cbobook.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtAuthor
            // 
            // 
            // 
            // 
            this.TxtAuthor.CustomButton.Image = null;
            this.TxtAuthor.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.TxtAuthor.CustomButton.Name = "";
            this.TxtAuthor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAuthor.CustomButton.TabIndex = 1;
            this.TxtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAuthor.CustomButton.UseSelectable = true;
            this.TxtAuthor.CustomButton.Visible = false;
            this.TxtAuthor.Lines = new string[0];
            this.TxtAuthor.Location = new System.Drawing.Point(86, 48);
            this.TxtAuthor.MaxLength = 32767;
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.PasswordChar = '\0';
            this.TxtAuthor.PromptText = "저자";
            this.TxtAuthor.ReadOnly = true;
            this.TxtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAuthor.SelectedText = "";
            this.TxtAuthor.SelectionLength = 0;
            this.TxtAuthor.SelectionStart = 0;
            this.TxtAuthor.ShortcutsEnabled = true;
            this.TxtAuthor.Size = new System.Drawing.Size(176, 23);
            this.TxtAuthor.TabIndex = 2;
            this.TxtAuthor.UseSelectable = true;
            this.TxtAuthor.WaterMark = "저자";
            this.TxtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAuthor.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(86, 15);
            this.TxtIdx.MaxLength = 32767;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.PromptText = "순번임";
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(176, 23);
            this.TxtIdx.TabIndex = 1;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMark = "순번임";
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "저자 :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "순번 :";
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(23, 63);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 23;
            this.DgvData.Size = new System.Drawing.Size(393, 364);
            this.DgvData.TabIndex = 1;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick_1);
            // 
            // FrmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.GrbDetail);
            this.Name = "FrmBooks";
            this.Text = "책 멤버 관리";
            this.GrbDetail.ResumeLayout(false);
            this.GrbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDetail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroTextBox TxtAuthor;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView DgvData;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel TxtReleaseDate;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox CboDivision;
        private MetroFramework.Controls.MetroTextBox TxtDescriptions;
        private MetroFramework.Controls.MetroTextBox TxtPrice;
        private MetroFramework.Controls.MetroTextBox TxtISBN;
        private MetroFramework.Controls.MetroTextBox Cbobook;
        private MetroFramework.Controls.MetroDateTime DtpReleaseDate;
    }
}