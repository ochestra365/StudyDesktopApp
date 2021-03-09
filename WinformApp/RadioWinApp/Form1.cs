using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioWinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            if(RgbKorea.Checked==false&& RgbJapan.Checked == false &&
                RdbChina.Checked == false && RgbOthers.Checked == false )
            {
                MessageBox.Show("국가 선택 필");
                return;
            }
            if(RgbMale.Checked==false&&RgbFemale.Checked==false)
            {
                MessageBox.Show("성별 선택 필");
                return;
            }

            if (RgbKorea.Checked)
                result= "국적:대한민국\n";
            else if (RdbChina.Checked)
            {
                result = "국적: 중국\n";
            }
            else if (RgbJapan.Checked)
            {
                result = "국적: 일본\n";
            }
            else if (RgbOthers.Checked)
            {
                result = "국적: 기타\n";
            }

            if (RgbMale.Checked)
                result += "성별: 남자";
            else if (RgbFemale.Checked)
                result += "성별: 여자";

            MessageBox.Show(result, "결과");
        }
    }
}
