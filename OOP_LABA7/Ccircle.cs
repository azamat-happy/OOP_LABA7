using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LABA7
{
    class CCircle : BaseClass
    {
        public CCircle(Point coordination)
        {
            point = coordination;
            pointMin = new Point(point.X - size, point.Y - size);
            pointMax = new Point(point.X + size, point.Y + size);
        }

        override public void draw(Graphics graphics)
        {
            ColorOfObject = getcolor();

            if (ColorOfObject == "Gray")
            {
                graphics.FillEllipse(Brushes.Gray, point.X -size, point.Y - size, 2 * size, 2 * size);
            }
            else if (ColorOfObject == "Purple")
            {
                graphics.FillEllipse(Brushes.Purple, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
            else if (ColorOfObject == "Orange")
            {
                graphics.FillEllipse(Brushes.Orange, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
            else if (ColorOfObject == "Green")
            {
                graphics.FillEllipse(Brushes.Green, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
            else if (ColorOfObject == "Yellow")
            {
                graphics.FillEllipse(Brushes.Yellow, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
        }

        public override void drawframe(Graphics graphics)
        {
            graphics.DrawEllipse(redPen, point.X - size, point.Y - size, 2 * size, 2 * size);
        }

        public override bool CheckIfObjectUnderCoordination(Point p)
        {
            return ((p.X - point.X) * (p.X - point.X) + (p.Y - point.Y) * (p.Y - point.Y) < size * size);
        }
        public override void save(StreamWriter stream)
        {
            stream.WriteLine("Circle");
            stream.WriteLine(point.X + " " + point.Y + " " + size + " " + ColorOfObject);
        }

        public override void load(StreamReader stream, AbstractFactory factory)
        {
            string[] data = stream.ReadLine().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            point.X = int.Parse(data[0]);
            point.Y = int.Parse(data[1]);
            size = int.Parse(data[2]);
            selectColor(data[3]);
            pointMin = new Point(point.X - size, point.Y - size);
            pointMax = new Point(point.X + size, point.Y + size);
        }
    }
}
