using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagWInApp
{
    public partial class FrmMain : Form
    {
        private bool isHello = false;//flag 상태를 저장하는 값 최초는 false이다.
        //글자를 Open, Close 분기점이다.
        public FrmMain()
        {
            InitializeComponent();//윈폼에서 가장 중요한 메서드이다.

            isHello = true;// 아침임
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LblGreeting.Text = string.Empty;
        }

        private void BtnGreeting_Click(object sender, EventArgs e)
        {
            if(isHello == true)
            {
                LblGreeting.Text = "Good Morning";
                isHello = false;
                BtnGreeting.Text = "저녁인사";
            }
            else if (isHello==false)
            {
                LblGreeting.Text = "Good Bye";
                isHello = true;
                BtnGreeting.Text = "아침인사";
            }
        }
    }
}
//조그만 화면에서 많은 기능을 해야 할 때, flag를 통해서 작업한다.