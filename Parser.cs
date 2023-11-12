using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProperAssignment
{
    public class Parser
    {
        Graphics g;
        private bool Fill;
        public Parser(Graphics g) 
        {
            this.g = g;
        }
        public bool Filled
        {
            get { return Fill; }
            set { Fill = value; }
        }
        public void parseCommand(string command)
        {
            command.Trim().ToLower();
            String[] hell = command.Split(' ');
            if (hell[0] == "fillon")
            {
                Filled = true;
            }
            if (hell[0] == "filloff")
            {
                Filled = false;
            }
            if (hell[0] == "circle")
            {
                int i = int.Parse(hell[1]);
                int f = int.Parse(hell[2]);
                int e = int.Parse(hell[3]);
                Circle c = new Circle(Color.Blue, i, f, e, Filled);
                c.draw(g);
            }

        }
    }
}
