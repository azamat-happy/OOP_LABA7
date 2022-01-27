using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LABA_6_1
{
    class CCircle : BaseClass
    {
        public CCircle(Point coordination)
        {
            point = coordination;
        }

        override public void draw(Graphics gr)
        {
            objcol = getcolor();

            if (objcol == "Gray")
            {
                gr.FillEllipse(Brushes.Gray, point.X - base.size, point.Y - base.size, 2 * base.size, 2 * base.size);
            }
            else if (objcol == "LightSeaGreen")
            {
                gr.FillEllipse(Brushes.LightSeaGreen, point.X - base.size, point.Y - base.size, 2 * base.size, 2 * base.size);
            }
            else if (objcol == "Orange")
            {
                gr.FillEllipse(Brushes.Orange, point.X - base.size, point.Y - base.size, 2 * base.size, 2 * base.size);
            }
            else if (objcol == "Green")
            {
                gr.FillEllipse(Brushes.Green, point.X - base.size, point.Y - base.size, 2 * base.size, 2 * base.size);
            }
            else if (objcol == "Yellow")
            {
                gr.FillEllipse(Brushes.Yellow, point.X - base.size, point.Y - base.size, 2 * base.size, 2 * base.size);
            }
        }

        public override void drawframe(Graphics gr)
        {
            gr.DrawEllipse(redPen, point.X - base.size, point.Y - base.size, 2 * base.size, 2 * base.size);
        }

        public override bool CheckIfObjectUnderCoordination(Point p)
        {
            return ((p.X - point.X) * (p.X - point.X) + (p.Y - point.Y) * (p.Y - point.Y) < base.size * base.size);
        }
        public override void save(StreamWriter stream)
        {
            stream.WriteLine("Circle");
            stream.WriteLine(point.X + " " + point.Y + " " + size + " " + objcol);
        }

        public override void load(StreamReader stream, AbstractFactory factory)
        {
            string[] data = stream.ReadLine().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            point.X = int.Parse(data[0]);
            point.Y = int.Parse(data[1]);
            size = int.Parse(data[2]);
            colorselect(data[3]);
            pointMin = new Point(point.X - size, point.Y - size);
            pointMax = new Point(point.X + size, point.Y + size);
        }
    }
}
