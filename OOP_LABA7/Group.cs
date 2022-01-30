using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LABA_6_1
{
    class Group : BaseClass
    {
        private Storage<BaseClass> bases;
        private int width, height;

        public Group()
        {
            bases = new Storage<BaseClass>();
        }

        public Group(int width, int height)
        {
            this.width = width; this.height = height;
            pointMin = new Point(width, height);
            pointMax = new Point(0, 0);
            bases = new Storage<BaseClass>();
        }

        public void add(BaseClass obj)
        {
            bases.push_back(obj);
        }

        public BaseClass GetAndDel(int p)
        {
            BaseClass tmp = bases[p];
            bases.getanddelete(p);
            return tmp;
        }

        public int GetCount()
        {
            return bases.Size();
        }

        public override void move(int dx, int dy, Point beg, Point end)
        {
            if (dy == 0)                                    //движемся по х
                if (dx > 0)
                {
                    if (pointMax.X + dx <= end.X)
                        for (int i = 0; i < bases.Size(); i++)
                            bases[i].move(dx, dy, beg, end);
                }
                else
                {
                    if (pointMin.X + dx >= beg.X)
                        for (int i = 0; i < bases.Size(); i++)
                            bases[i].move(dx, dy, beg, end);
                }
            else if (dx == 0)                               //движемся по y
                if (dy > 0)
                {
                    if (pointMax.Y + dy <= end.Y)
                        for (int i = 0; i < bases.Size(); i++)
                            bases[i].move(dx, dy, beg, end);
                }
                else
                {
                    if ((pointMin.Y + dy >= beg.Y))
                        for (int i = 0; i < bases.Size(); i++)
                            bases[i].move(dx, dy, beg, end);
                }
            findframe();
        }

        public override void resize(int dx, Point begin, Point end)
        {
            if (dx > 0)
            {
                if ((pointMax.X + dx < end.X) && (pointMax.Y + dx < end.Y) && (pointMin.X - dx > begin.X) && (pointMin.Y - dx > begin.Y))
                {
                    for (int i = 0; i < bases.Size(); i++)
                        bases[i].resize(dx, begin, end);
                }
            }
            else
            {
                for (int i = 0; i < bases.Size(); i++)
                    bases[i].resize(dx, begin, end);
            }
            findframe();
        }

        public override bool CheckIfObjectUnderCoordination(Point point)
        {
            for (int i = 0; i < bases.Size(); i++)
                if (bases[i].CheckIfObjectUnderCoordination(point) == true) return true;
            return false;
        }
               
        public override void draw(Graphics gr)
        {
            for (int i = bases.Size() - 1; i >= 0; i--)
                bases[i].draw(gr);
            
        }
        public override void colorselect(string color1)
        {
            for (int i = bases.Size() - 1; i >= 0; i--)
                bases[i].colorselect(color1);
        }
        private void findframe()
        {
            pointMin.X = width;
            pointMin.Y = height;
            pointMax.X = 0;
            pointMax.Y = 0;

            for (int i = 0; i < bases.Size(); i++)
            {
                if (bases[i].getpointMin().X <= pointMin.X)
                {
                    pointMin.X = bases[i].getpointMin().X;
                }

                if (bases[i].getpointMin().Y <= pointMin.Y)
                {
                    pointMin.Y = bases[i].getpointMin().Y;
                }


                if (bases[i].getpointMax().X >= pointMax.X)
                {
                    pointMax.X = bases[i].getpointMax().X;
                }


                if (bases[i].getpointMax().Y >= pointMax.Y)
                {
                    pointMax.Y = bases[i].getpointMax().Y;
                }
            }
        }

        public override void drawframe(Graphics gr)
        {
            findframe();
            gr.DrawRectangle(redPen, pointMin.X, pointMin.Y, pointMax.X - pointMin.X, pointMax.Y - pointMin.Y);
        }

        public override bool isgroup()
        {
            return true;
        }

        public override void save(StreamWriter stream)
        {
            stream.WriteLine("Group");
            stream.WriteLine(GetCount());
            for (int i = 0; i < GetCount(); i++)
                bases[i].save(stream);
        }

        public override void load(StreamReader stream, AbstractFactory factory)
        {
            int h = Convert.ToInt32(stream.ReadLine());
            for (int i = 0; i < h; i++)
            {
                string t = stream.ReadLine();
                bases.push_back(factory.createBase(t, width, height));
                bases[i].load(stream, factory);
            }
            findframe();
        }

        ~Group()
        {
            for (int i = 0; i < bases.Size(); i++)
                bases[i] = null;
            bases = null;
        }
    }
}
