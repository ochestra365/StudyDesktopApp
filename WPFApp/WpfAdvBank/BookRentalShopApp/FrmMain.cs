using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BookRentalShopApp
{
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void FrmMain_Shown(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void MnuDivCode_Click(object sender, EventArgs e)
        {
            FrmDivCode frm = new FrmDivCode();
            InitChildForm(frm, "도서관리");
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this, "종료하시겠어요?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;//프로그램 종료 안함.
            }
        }
    
        private void MnuMember_Click(object sender, EventArgs e)
        {
            FrmMember frm = new FrmMember();
            InitChildForm(frm, "멤버관리");
        }

        private void MnuBooks_Click(object sender, EventArgs e)
        {
            FrmBooks frm = new FrmBooks();
            InitChildForm(frm, "책관리");
        }

        private void InitChildForm(Form frm, string strTitle)
        {
            frm.Text = strTitle;
            frm.Dock = DockStyle.Fill;
            frm.MdiParent = this;//FrmMain
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = this.ClientSize.Width - 1000;//추가
            frm.Height = this.Height - menuStrip1.Height;//추가
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void MnuRental_Click(object sender, EventArgs e)
        {
            FrmRental frm = new FrmRental();
            InitChildForm(frm, "대여관리");
        }
    }
}
//실제 비즈니스 로직보다 사용자 편의성을 위한 코딩이 더 많을 수 있다.
//계속 써야 하는 것들을 모듈화해서 편하게 만든다.
/*
 UI가 비슷하게 뜨는 게, 고칠 수 있다고 생각하면 엄청나게 큰 실수를 범할 수 있다. 
 */