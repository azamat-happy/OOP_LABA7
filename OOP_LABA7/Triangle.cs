using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LABA7
{
    class Triangle : BaseClass
    {
        private Point point1;
        private Point point2;
        private Point point3;

        public Triangle(Point coordination)
        {
            point = coordination;

            pointMin = new Point(point.X - size, point.Y - size);
            pointMax = new Point(point.X + size, point.Y + size);

            point1.X = point.X - base.size;
            point1.Y = point.Y + base.size;
            point2.X = point.X + base.size;
            point2.Y = point.Y + base.size;
            point3.X = point.X;
            point3.Y = point.Y - base.size;

            redPen = new Pen(Color.Red);
            redPen.Width = 2;
        }

        override public void ChangeSize(int x, Point start, Point end)
        {
            if (x >= 0)
            {
                if (point3.Y - x >= start.Y && point2.X + x <= end.X && point2.Y + x <= end.Y && point1.X - x >= start.X && point1.Y + x <= end.Y)
                {
                    size += x;
                }
            }
            else
            {
                if (point3.Y < point2.Y)
                {
                    size += x;
                }
            }
            point1.X = point.X - size;
            point1.Y = point.Y + size;
            point2.X = point.X + size;
            point2.Y = point.Y + size;
            point3.X = point.X;
            point3.Y = point.Y - size;

            pointMin.X = point.X - size;
            pointMin.Y = point.Y - size;
            pointMax.X = point.X + size;
            pointMax.Y = point.Y + size;
        }

        
        override public void draw(Graphics gr)
        {
            Point[] points = new Point[3];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;

            ColorOfObject = getcolor();
            if (ColorOfObject == "Gray")
            {
                gr.FillPolygon(Brushes.Gray, points);
            }
            else if (ColorOfObject == "Purple")
            {
                gr.FillPolygon(Brushes.Purple, points);
            }
            else if (ColorOfObject == "Orange")
            {
                gr.FillPolygon(Brushes.Orange, points);
            }
            else if (ColorOfObject == "Green")
            {
                gr.FillPolygon(Brushes.Green, points);
            }
            else if (ColorOfObject == "Yellow")
            {
                gr.FillPolygon(Brushes.Yellow, points);
            }
        }
        override public void drawframe(Graphics gr)
        {
            Point[] points = new Point[3];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            gr.DrawPolygon(redPen, points);
        }

        public override void move(int dx, int dy, Point beg, Point end)
        {
            if (dy == 0)                                    //движемся по х
            {
                if (dx >= 0)
                {
                    if (point2.X + dx < end.X)
                    {
                        point.X += dx;
                    }
                }
                else
                {
                    if (point1.X - dx > beg.X)
                    {
                        point.X += dx;
                    }
                }
            }
            else if (dx == 0)                               //движемся по y
            {
                if (dy > 0)                                             //вниз
                {
                    if (point2.Y + dy < end.Y && point1.Y + dy < end.Y)
                    {
                        point.Y += dy;
                    }
                }
                else
                {                                                         //вверх
                    if (point3.Y - dy > beg.Y)
                    {
                        point.Y += dy;
                    }
                }
            }
            point1.X = point.X - size;
            point1.Y = point.Y + size;
            point2.X = point.X + size;
            point2.Y = point.Y + size;
            point3.X = point.X;
            point3.Y = point.Y - size;

            pointMin.X = point.X - size;
            pointMin.Y = point.Y - size;
            pointMax.X = point.X + size;
            pointMax.Y = point.Y + size;
        }
        override public bool CheckIfObjectUnderCoordination(Point p)
        {
            if (((((point1.X - p.X) * (point2.Y - point1.Y) - (point2.X - point1.X) * (point1.Y - p.Y))) > 0) && ((((point2.X - p.X) * (point3.Y - point2.Y) - (point3.X - point2.X) * (point2.Y - p.Y))) > 0) && (((point3.X - p.X) * (point1.Y - point3.Y) - (point1.X - point3.X) * (point3.Y - p.Y)) > 0))
                return true;
            if (((((point1.X - p.X) * (point2.Y - point1.Y) - (point2.X - point1.X) * (point1.Y - p.Y))) < 0) && ((((point2.X - p.X) * (point3.Y - point2.Y) - (point3.X - point2.X) * (point2.Y - p.Y))) < 0) && (((point3.X - p.X) * (point1.Y - point3.Y) - (point1.X - point3.X) * (point3.Y - p.Y)) < 0))
                return true;
            if (((((point1.X - p.X) * (point2.Y - point1.Y) - (point2.X - point1.X) * (point1.Y - p.Y))) == 0) || ((((point2.X - p.X) * (point3.Y - point2.Y) - (point3.X - point2.X) * (point2.Y - p.Y))) == 0) || (((point3.X - p.X) * (point1.Y - point3.Y) - (point1.X - point3.X) * (point3.Y - p.Y)) == 0))
                return true;
            else
                return false;
        }
        public override void save(StreamWriter stream)
        {
            stream.WriteLine("Triangle");
            stream.WriteLine(point.X + " " + point.Y + " " + base.size + " " + ColorOfObject);
        }

        public override void load(StreamReader stream, AbstractFactory factory)
        {
            string[] data = stream.ReadLine().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            point.X = int.Parse(data[0]);
            point.Y = int.Parse(data[1]);
            base.size = int.Parse(data[2]);
            selectColor(data[3]);
            pointMin = new Point(point.X - base.size, point.Y - base.size);
            pointMax = new Point(point.X + base.size, point.Y + base.size);
            point1.X = point.X - base.size;
            point1.Y = point.Y + base.size;
            point2.X = point.X + base.size;
            point2.Y = point.Y + base.size;
            point3.X = point.X;
            point3.Y = point.Y - base.size;
        }

    }

}
