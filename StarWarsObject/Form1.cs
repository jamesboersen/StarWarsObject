using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Shape : X-Wing

namespace StarWarsObject
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Xwing(0, 0, 2, 2);
        }

        public void Xwing(float x, float y, float width, float height)
        {
            //Pen
            Pen shipPen = new Pen(Color.White);
            
            //Ship
            //Top Line
            g.DrawLine(shipPen, 130 / width + x, 200 / height + y, 250 / width + x, 180 / height + y);
            //Bottom Line
            g.DrawLine(shipPen, 130 / width + x, 220 / height + y, 250 / width + x, 220 / height + y);
            //Wing
            g.DrawRectangle(shipPen, 220 / width + x, 190 / height + y, 70 / width + x, 10 / height + y);
            //Back of Ship Top Part
            g.DrawLine(shipPen, 250 / width + x, 180 / height + y, 270 / width + x, 190 / height + y);
            //Wing 2
            g.DrawRectangle(shipPen, 220 / width + x, 210 / height + y, 70 / width + x, 10 / height + y);
            //Arc at Front of Ship
            g.DrawArc(shipPen, 123 / width + x, 200 / height + y, 21 / width, 21 / height, 110, 137);
            //Back of Ship
            g.DrawLine(shipPen, 270 / width + x, 200 / height + y, 260 / width + x, 210 / height + y);
        }
    }
}
