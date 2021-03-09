using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxWinAPp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
      
        private void BtnResult_Click(object sender, EventArgs e)
        {
            string checkState = string.Empty;

            List<CheckBox> boxes = new List<CheckBox> 
            { 
                ChkApple,ChkOrange,ChkStrawBerry,ChkBanana,ChkPear,ChkDurian
            };

            foreach (var item in boxes)
            {
                checkState += $"{item.Text}:{item.Checked}\n";
            }
            MessageBox.Show(checkState, "체크상태");

            string summary = $"좋아하는 과일은 : ";

            foreach (var item in boxes)
            {
                if (item.Checked)//참인 경우에 실행하는 것이다. 항상 참인 것을 따른다.
                    summary += item.Text + "";
            }
            MessageBox.Show(summary, "좋아하는 과일 리스트");    
        }
    }
}
//배열은 왠만하면 안쓰는 것이 좋다. 배열은 정말 급하다 할 때, 사용하는 것이다.