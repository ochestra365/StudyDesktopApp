﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGraphicEditer
{
    enum DrawMode
    {
        LINE,
        RECTANGLE,
        CIRCLE,
        CURVED_LINE
    }

    public partial class FrmMain : Form
    {
        private DrawMode mode;
        private Graphics g;
        private Pen pen;
        private Pen eraser;
        private Point startP, endP, currP, prevP;
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            StsCurrent.Text = "";

            g = CreateGraphics();
            this.pen = new Pen(Color.Black, 2);
            StsCurrent.Text = "Line Mode";
            this.mode = DrawMode.LINE;
            this.BackColor = Color.White;
            this.eraser = new Pen(Color.White, 2);
            //class 멤버변수로써 사용한다.
        }

        private void TlmLine_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.LINE;
            StsCurrent.Text = "Line Mode";
        }
        //d
        private void TlmRecSquare_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.RECTANGLE;
            StsCurrent.Text = "Rectangle Mode";
        }

        private void TlmCircle_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.CIRCLE;
            StsCurrent.Text = "Circle Mode";

        }

        private void TlmCurvedLine_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.CURVED_LINE;
            StsCurrent.Text = "Curved_Line Mode";
        }

        private void TlmColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog =new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pen.Color = dialog.Color;
            }
        }
    }
}
