using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProperAssignment
{
    public partial class Form1 : Form
    {
        Bitmap myBitmap = new Bitmap(640, 480);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(myBitmap, 0, 0);
            Refresh();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(myBitmap);
            Pen p = new Pen(Color.Red, 2);
            g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
