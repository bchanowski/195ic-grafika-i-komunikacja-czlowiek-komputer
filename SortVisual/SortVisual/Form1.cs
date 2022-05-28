using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisual
{
    public partial class Form1 : Form
    {
        int[] TheArray;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            int NumEntries = panel1.Width;
            int MaxVal = panel1.Height;
            TheArray = new int[NumEntries];
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), 0, 0, NumEntries, MaxVal);
            Random rand = new Random();
            for (int i = 0; i < NumEntries; i++)
            {
                TheArray[i] = rand.Next(0, MaxVal);
            }
            for(int i = 0; i < NumEntries; i++)
            {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), i, MaxVal - TheArray[i], 1, MaxVal);
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Sort so = new SortBubble();
            so.DoWork(TheArray, g, panel1.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
