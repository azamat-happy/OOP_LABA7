using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LABA7
{
    abstract class BaseClass
    {
        protected bool isChoose = false;
        private string color = "Gray";
        protected int size = 50;
        protected Point point = new Point(0, 0);
        protected Point pointMin;
        protected Point pointMax;
        protected string ColorOfObject;
        protected Pen normPen = new Pen(Color.Pink, 5);
        protected Pen redPen = new Pen(Color.Red, 2);

        virtual public void draw(Graphics gr) { }

        virtual public void drawframe(Graphics gr) { }

        virtual public void  selectColor(string selectColor)
        {
            color = selectColor;
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

        virtual public void move(int dx, int dy, Point begin, Point end)
        {
            //движение по оси Х
            if (dy == 0)                                    
                if (dx > 0)
                {
                    if (point.X + size + dx <= end.X)
                        point.X = point.X + dx;
                }
                else
                {
                    if (point.X - size + dx >= begin.X)
                        point.X = point.X + dx;
                }
            //движение по оси Y
            else if (dx == 0)                             
                if (dy > 0)
                {
                    if (point.Y + size + dy <= end.Y)
                        point.Y = point.Y + dy;
                }
                else
                {
                    if ((point.Y - size + dy >= begin.Y))
                        point.Y = point.Y + dy;
                }
            pointMin.X = point.X - size;
            pointMin.Y = point.Y - size;
            pointMax.X = point.X + size;
            pointMax.Y = point.Y + size;
        }


        virtual public void ChangeSize(int dx, Point begin, Point end)
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

        virtual public bool CheckIfObjectUnderCoordination(Point point)              
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
        virtual public bool isGroup()
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

