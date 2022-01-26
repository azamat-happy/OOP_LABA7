using System;
using System.Collections.Generic;
using System.Drawing;
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

            point1.X = point.X - size;
            point1.Y = point.Y + size;
            point2.X = point.X + size;
            point2.Y = point.Y + size;
            point3.X = point.X;
            point3.Y = point.Y - size;

            redPen = new Pen(Color.Red);
            redPen.Width = 2;
        }

        override public void resize(int x, Point start, Point end)
        {
            if (x >= 0)
            {
                if (point3.Y - x > start.Y && point2.X + x < end.X && point2.Y + x < end.Y && point1.X - x > start.X && point1.Y + x < end.Y)
                {
                    point3.Y = point3.Y - x;

                    point1.X = point1.X - x;
                    point1.Y = point1.Y + x;

                    point2.X = point2.X + x;
                    point2.Y = point2.Y + x;
                }
            }
            else
            {
                if (point3.Y < point2.Y)
                {
                    {
                        point3.Y = point3.Y - x;

                        point1.X = point1.X - x;
                        point1.Y = point1.Y + x;

                        point2.X = point2.X + x;
                        point2.Y = point2.Y + x;
                    }
                }
            }
        }

        
        override public void draw(Graphics gr, BaseClass obj)
        {
            Point[] points = new Point[3];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;

            string objcol = obj.getcolor();
            if (objcol == "Gray")
            {
                gr.FillPolygon(Brushes.Gray, points);
            }
            else if (objcol == "LightSeaGreen")
            {
                gr.FillPolygon(Brushes.LightSeaGreen, points);
            }
            else if (objcol == "Orange")
            {
                gr.FillPolygon(Brushes.Orange, points);
            }
            else if (objcol == "Green")
            {
                gr.FillPolygon(Brushes.Green, points);
            }
            else if (objcol == "Yellow")
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
                        point1.X = point1.X + dx;
                        point2.X = point2.X + dx;
                        point3.X = point3.X + dx;
                    }
                }
                else
                {
                    if (point1.X - dx > beg.X)
                    {
                        point1.X = point1.X + dx;
                        point2.X = point2.X + dx;
                        point3.X = point3.X + dx;
                    }
                }
            }
            else if (dx == 0)                               //движемся по y
            {
                if (dy > 0)                                             //вниз
                {
                    if (point2.Y + dy < end.Y && point1.Y + dy < end.Y)
                    {
                        point1.Y = point1.Y + dy;
                        point2.Y = point2.Y + dy;
                        point3.Y = point3.Y + dy;
                    }
                }
                else
                {                                                         //вверх
                    if (point3.Y - dy > beg.Y)
                    {
                        point1.Y = point1.Y + dy;
                        point2.Y = point2.Y + dy;
                        point3.Y = point3.Y + dy;
                    }
                }
            }
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

    }
}
