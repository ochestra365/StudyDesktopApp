using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalculatorApp
{
    public partial class FrmMain : Form
    {
        public double saved { get; set; }//연산자 이전의 숫자를 저장
        public double Memory { get; set; }
        public bool MemFlag { get; set; }
        public bool PercentFlag { get; set; }
        public char Op { get; set; }
        public bool OpFalg { get; set; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TxtExp.Text =TxtResult.Text= "";
            BtnMC.Enabled = BtnMR.Enabled = false;
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var str = btn.Text;//0~9

            TxtResult.Text += str;
        }

        private void BtnOp_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            saved = double.Parse(TxtResult.Text);//
            TxtExp.Text += $"{TxtResult.Text}{btn.Text}";
            Op = btn.Text[0];//+
            OpFalg = true;

            TxtResult.Text = "";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            var value = double.Parse(TxtResult.Text);

            switch (Op)
            {
                case '+':
                    TxtResult.Text = (saved + value).ToString();
                    break;
                case '-':
                    TxtResult.Text = (saved - value).ToString();
                    break;
                case 'x':
                    TxtResult.Text = (saved * value).ToString();
                    break;
                    TxtResult.Text = (saved / value).ToString();
                case '÷':
                    break;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text = "";
            saved = 0;
            Op = '\0';
            OpFalg = false;
            PercentFlag = false;
        }
    }
}
