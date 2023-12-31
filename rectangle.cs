﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProperAssignment
{
    public class Rectangle : Shape
    {
        protected int width, height;
        protected bool fill;
        public Rectangle(Color colour, int x, int y, int width, int height, bool fill) : base(colour, x, y)
        {

            this.width = width; //the only thingthat is different from shape
            this.height = height;
            this.fill = fill;
        }


        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            if (fill)
            {
                g.FillRectangle(b, x, y, width, height);
            }
            else
            {
                g.DrawRectangle(p, x, y, width, height);
            }
        }
    }
}
