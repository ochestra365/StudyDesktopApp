using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LableTestApp2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LblAutoSize.Text = LblManualSize.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sample1 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit ut tempora earum quia voluptatum cumque quod maxime nobis ex? Maiores mollitia est odit odio libero quidem quo voluptates, obcaecati perferendis?";
            string sample2 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit ut tempora earum quia voluptatum cumque quod maxime nobis ex? Maiores mollitia est odit odio libero quidem quo voluptates, obcaecati perferendis?";

            LblAutoSize.Text = sample1;
            LblManualSize.Text = sample2;
        }
    }
}
