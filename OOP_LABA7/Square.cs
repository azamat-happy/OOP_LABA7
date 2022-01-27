using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LABA_6_1
{
    class Square : BaseClass
    {
        public Square(Point coordination)
        {
            point = coordination;
            pointMin = new Point(point.X - size, point.Y - size);
            pointMax = new Point(point.X + size, point.Y + size);
        }


        override public void draw(Graphics gr)
        {
           objcol = getcolor();
            if (objcol == "Gray")
            {
                gr.FillRectangle(Brushes.Gray, point.X - base.size, point.Y - base.size, 2 * base.size, 2 * base.size);
            }
            else if (objcol == "LightSeaGreen")
            {
                gr.FillRectangle(Brushes.LightSeaGreen, point.X - base.size, point.Y - base.size, 2 * base.size, 2 * base.size);
            }
            else if (objcol == "Orange")
            {
                gr.FillRectangle(Brushes.Orange, point.X - base.size, point.Y - base.size, 2 * base.size, 2 * base.size);
            }
            else if (objcol == "Green")
            {
                gr.FillRectangle(Brushes.Green, point.X - base.size, point.Y - base.size, 2 * base.size, 2 * base.size);
            }
            else if (objcol == "Yellow")
            {
                gr.FillRectangle(Brushes.Yellow, point.X - base.size, point.Y - base.size, 2 * base.size, 2 * base.size);
            }
        }

        override public void drawframe(Graphics gr)
        {
            gr.DrawRectangle(redPen, point.X - base.size, point.Y - base.size, 2 * base.size, 2 * base.size);
        }
        override public bool CheckIfObjectUnderCoordination(Point p)
        {
            if ((p.X > point.X - base.size) && (p.Y > point.Y - base.size) && (p.X < point.X + base.size) && (p.Y < point.Y + base.size))
            {
                return true;
            }
            else return false;
        }
        public override void save(StreamWriter stream)
        {
            stream.WriteLine("Square");
            stream.WriteLine(point.X + " " + point.Y + " " + base.size + " " + objcol);
        }

        public override void load(StreamReader stream, AbstractFactory factory)
        {
            string[] data = stream.ReadLine().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            point.X = int.Parse(data[0]);
            point.Y = int.Parse(data[1]);
            base.size = int.Parse(data[2]);
            colorselect(data[3]);
            pointMin = new Point(point.X - base.size, point.Y - base.size);
            pointMax = new Point(point.X + base.size, point.Y + base.size);
        }

    }
}
