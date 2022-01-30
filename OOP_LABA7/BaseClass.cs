using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LABA_6_1
{
    abstract class BaseClass
    {
        protected bool isChoose = false;
        private string color = "Gray";
        protected int size = 50;

        protected Point point = new Point(0, 0);
        protected Pen redPen = new Pen(Color.Red, 2);

        protected Point pointMax;
        protected Point pointMin;
        protected string objcol;
        protected Pen normPen = new Pen(Color.Pink, 5);

        virtual public void draw(Graphics gr) { }

        virtual public void drawframe(Graphics gr) { }

        virtual public void  colorselect(string color_select)
        {
            color = color_select;
        }

        public string getcolor()
        {
            return color;
        }

        public void setselect(bool choose)
        {
            isChoose = choose;
        }

        public bool getselect()
        {
            return isChoose;
        }

        virtual public void move(int dx, int dy, Point beg, Point end)
        {
            if (dy == 0)                                    //движемся по х
                if (dx > 0)
                {
                    if (point.X + size + dx <= end.X)
                        point.X = point.X + dx;
                }
                else
                {
                    if (point.X - size + dx >= beg.X)
                        point.X = point.X + dx;
                }
            else if (dx == 0)                               //движемся по y
                if (dy > 0)
                {
                    if (point.Y + size + dy <= end.Y)
                        point.Y = point.Y + dy;
                }
                else
                {
                    if ((point.Y - size + dy >= beg.Y))
                        point.Y = point.Y + dy;
                }
            pointMin.X = point.X - size;
            pointMin.Y = point.Y - size;
            pointMax.X = point.X + size;
            pointMax.Y = point.Y + size;
        }


        virtual public void resize(int dx, Point begin, Point end)
        {
            if (dx >= 0)
            {
                if ((point.X + size + dx < end.X) && (point.Y + size + dx < end.Y) && (point.X - size - dx > begin.X) && (point.Y - size - dx > begin.Y))
                    if (2 * size + dx < 600)
                        size = size + dx;
            }
            else
            {
                if (2 * size + dx > 10)
                    size = size + dx;
            }
            pointMin.X = point.X - size;
            pointMin.Y = point.Y - size;
            pointMax.X = point.X + size;
            pointMax.Y = point.Y + size;
        }

        virtual public bool CheckIfObjectUnderCoordination(Point point)              //входит ли курсор в фигуру
        {
            return false;
        }
        public Point getpointMin()
        {
            return pointMin;
        }

        public Point getpointMax()
        {
            return pointMax;
        }
        virtual public bool isgroup()
        {
            return false;
        }

        virtual public void save(StreamWriter stream)
        {
            return;
        }

        virtual public void load(StreamReader stream, AbstractFactory factory)
        {
            return;
        }


    }
}

