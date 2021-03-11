﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGraphicEditor
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

            this.g = CreateGraphics();
            pen = new Pen(Color.HotPink, 2);
            StsCurrent.Text = "Line Mode";
            this.mode = DrawMode.LINE;
            this.BackColor = Color.White;
            this.eraser = new Pen(Color.White, 2);
        }

        private void TlmLine_Click(object sender, EventArgs e)
        {
            StsCurrent.Text = "Line Mode";
            this.mode = DrawMode.LINE;
        }

        private void TlmRectangle_Click(object sender, EventArgs e)
        {
            StsCurrent.Text = "Rectangle Mode";
            this.mode = DrawMode.RECTANGLE;
        }

        private void TlmCircle_Click(object sender, EventArgs e)
        {
            StsCurrent.Text = "Circle Mode";
            this.mode = DrawMode.CIRCLE;
        }

        private void TlmCurvedLine_Click(object sender, EventArgs e)
        {
            StsCurrent.Text = "Curved Line Mode";
            this.mode = DrawMode.CURVED_LINE;
        }

        private void TlmColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.pen.Color = dialog.Color;
            }
        }
    }
}
