using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace WinChartApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnRegen_Click(object sender, EventArgs e)
        {
            GenNewChart();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "중간고사 성적";
            ChpScore.Titles.Add("중간고사 성적");
            GenNewChart();
        }

        private void GenNewChart()
        {
            Random rand = new Random();//series는 같은 데이터가 모이는 장소를 의미한다. 이것은 배열이다.
            ChpScore.Series[0].Points.Clear();
            for (int i = 0; i < 10; i++)
            {
                ChpScore.Series["Score"].Points.Add(rand.Next(10,100));
            }
            ChpScore.Series[0].LegendText = "수학";
            ChpScore.Series[0].ChartType = SeriesChartType.Column;
        }
    }
}
