﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProperAssignment
{
    public partial class Form1 : Form
    {

        Bitmap myBitmap = new Bitmap(640, 480);
        Graphics bitmapG;
        private Parser parser;

        public Form1()
        {
            InitializeComponent();
            bitmapG = Graphics.FromImage(myBitmap);
            parser = new Parser(bitmapG);

        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            string mytext = textBox1.Text;
            parser.parseCommand(mytext);
            textBox1.Clear();
            pictureBox1.Refresh();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "run")
            {
                string richText = richTextBox1.Text;
                Parser parser = new Parser(bitmapG);
                parser.parserCommand(richText);
                pictureBox1.Refresh();
            }
        }    

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
 
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(myBitmap, 0, 0);
        }
    }
}
