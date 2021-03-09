using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChangerApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /*private void TrcRed_Scroll(object sender, EventArgs e)
        {
            TxtRed.Text = TrcRed.Value.ToString();
            PnlResult.BackColor = Color.FromArgb(TrcRed.Value, TrcGreen.Value, TrcBlue.Value);
        }

        private void TrcGreen_Scroll(object sender, EventArgs e)
        {
            TxtGreen.Text = TrcGreen.Value.ToString();
            PnlResult.BackColor = Color.FromArgb(TrcRed.Value, TrcGreen.Value, TrcBlue.Value);
        }

        private void TrcBlue_Scroll(object sender, EventArgs e)
        {
            TxtBlue.Text = TrcBlue.Value.ToString();
            PnlResult.BackColor = Color.FromArgb(TrcRed.Value, TrcGreen.Value, TrcBlue.Value);
        }
*/
        private void Trackbar_Scroll(object sender, EventArgs e)
        {
            TxtRed.Text = TrcRed.Value.ToString();
            TxtGreen.Text = TrcGreen.Value.ToString();
            TxtBlue.Text = TrcBlue.Value.ToString();

            PnlResult.BackColor = Color.FromArgb(TrcRed.Value, TrcGreen.Value, TrcBlue.Value);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
             saveFileDialog1.ShowDialog();
        }
    }
}
//같은 작업을 하는 것이라면 하나의 메0서드로 묶는 것이 경제적이다.