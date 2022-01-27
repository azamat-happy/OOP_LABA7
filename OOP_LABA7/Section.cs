using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace OOP_LABA_6_1
{
    class Section : BaseClass
    {
        private Point point1;
        private Point point2;
        Pen pen;

        public Section(Point coordination)
        {
            point = coordination;
            point1 = new Point(point.X - base.size, point.Y - base.size);
            point2 = new Point(point.X + base.size, point.Y + base.size);
            redPen = new Pen(Color.Red);
            redPen.Width = 2;
        }

        public override void resize(int dx, Point start, Point end)
        {
            if (dx >= 0)
            {
                if ((point2.X + dx < end.X) && (point2.Y + dx < end.Y) && (point1.X - dx > start.X) && (point1.Y - dx > start.Y))
                {
                    point2.X += dx;
                    point2.Y += dx;
                    point1.X -= dx;
                    point1.Y -= dx;
                }
            }
            else
            {
                if (point2.X + dx > point1.X - dx)
                {
                    {
                        point2.X += dx;
                        point2.Y += dx;
                        point1.X -= dx;
                        point1.Y -= dx;
                    }
                }
            }
        }


        override public bool CheckIfObjectUnderCoordination(Point p)
        {
            if (((p.X <= point2.X + 10) && (p.Y <= point2.Y + 10) && (p.X >= point2.X - 10) && (p.Y >= point2.Y - 10)) || ((p.X <= point1.X + 10) && (p.Y <= point1.Y + 10) && (p.X >= point1.X - 10) && (p.Y >= point1.Y - 10)))
                return true;
            else
                return false;
        }

        override public void draw(Graphics gr)
        {
            objcol = getcolor();
            if (objcol == "Gray")
            {
                pen = new Pen(Color.Gray);
                pen.Width = 2;
                gr.DrawLine(pen, point2, point1);
            }
            else if (objcol == "LightSeaGreen")
            {
                pen = new Pen(Color.LightSeaGreen);
                pen.Width = 2;
                gr.DrawLine(pen, point2, point1);
            }
            else if (objcol == "Orange")
            {
                pen = new Pen(Color.Orange);
                pen.Width = 2;
                gr.DrawLine(pen, point2, point1);
            }
            else if (objcol == "Green")
            {
                pen = new Pen(Color.Green);
                pen.Width = 2;
                gr.DrawLine(pen, point2, point1);
            }
            else if (objcol == "Yellow")
            {
                pen = new Pen(Color.Yellow);
                pen.Width = 2;
                gr.DrawLine(pen, point2, point1);
            }
        }

        override public void drawframe(Graphics gr)
        {
            gr.DrawLine(redPen, point2, point1);
        }

        public override void move(int dx, int dy, Point beg, Point end)
        {
            if (dy == 0)                                    //движемся по х
            {
                if ((point2.X + dx < end.X) && (point1.X + dx > beg.X))
                {
                    point1.X += dx;
                    point2.X += dx;
                }
            }
            else if (dx == 0)                               //движемся по y
            {
                if ((point2.Y + dy < end.Y) && (point1.Y + dy > beg.Y))
                {
                    point1.Y += dy;
                    point2.Y += dy;
                }
            }
        }
        public override void save(StreamWriter stream)
        {
            stream.WriteLine("Section");
            stream.WriteLine(point.X + " " + point.Y + " " + base.size + " " + objcol);
        }
        public override void load(StreamReader stream, AbstractFactory factory)
        {
            string[] data = stream.ReadLine().Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            point.X = int.Parse(data[0]);
            point.Y = int.Parse(data[1]);
            size = int.Parse(data[2]);
            colorselect(data[3]);
            pointMin = new Point(point.X - base.size, point.Y - size);
            pointMax = new Point(point.X + size, point.Y + size);
            point1 = new Point(point.X + size, point.Y + size);
            point2 = new Point(point.X - size, point.Y - size);
        }
    }
}
