using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LABA7
{
    class Group : BaseClass
    {
        private Storage<BaseClass> group;
        private int width, height;

        public Group(int width, int height)
        {
            this.width = width; this.height = height;
            pointMin = new Point(width, height);
            pointMax = new Point(0, 0);
            group = new Storage<BaseClass>();
        }

        public void add(BaseClass obj)
        {
            group.push_back(obj);
        }

        public BaseClass GetAndDel(int p)
        {
            BaseClass tmp =group.getanddelete(p);
            return tmp;
        }

        public int GetCount()
        {
            return group.Size();
        }

        public override void move(int dx, int dy, Point beg, Point end)
        {
            if (dy == 0)                                   
                if (dx > 0)
                {
                    if (pointMax.X + dx <= end.X)
                        for (int i = 0; i < group.Size(); i++)
                            group[i].move(dx, dy, beg, end);
                }
                else
                {
                    if (pointMin.X + dx >= beg.X)
                        for (int i = 0; i < group.Size(); i++)
                            group[i].move(dx, dy, beg, end);
                }
            else if (dx == 0)                               
                if (dy > 0)
                {
                    if (pointMax.Y + dy <= end.Y)
                        for (int i = 0; i < group.Size(); i++)
                            group[i].move(dx, dy, beg, end);
                }
                else
                {
                    if ((pointMin.Y + dy >= beg.Y))
                        for (int i = 0; i < group.Size(); i++)
                            group[i].move(dx, dy, beg, end);
                }
            findframe();
        }

        public override void ChangeSize(int dx, Point begin, Point end)
        {
            if (dx > 0)
            {
                if ((pointMax.X + dx < end.X) && (pointMax.Y + dx < end.Y) && (pointMin.X - dx > begin.X) && (pointMin.Y - dx > begin.Y))
                {
                    for (int i = 0; i < group.Size(); i++)
                        group[i].ChangeSize(dx, begin, end);
                }
            }
            else
            {
                for (int i = 0; i < group.Size(); i++)
                    group[i].ChangeSize(dx, begin, end);
            }
            findframe();
        }

        public override bool CheckIfObjectUnderCoordination(Point point)
        {
            for (int i = 0; i < group.Size(); i++)
                if (group[i].CheckIfObjectUnderCoordination(point) == true) return true;
            return false;
        }
               
        public override void draw(Graphics gr)
        {
            for (int i = group.Size() - 1; i >= 0; i--)
                group[i].draw(gr);
            
        }
        public override void selectColor(string color1)
        {
            for (int i = group.Size() - 1; i >= 0; i--)
                group[i].selectColor(color1);
        }
        private void findframe()
        {
            pointMin.X = width;
            pointMin.Y = height;
            pointMax.X = 0;
            pointMax.Y = 0;

            for (int i = 0; i < group.Size(); i++)
            {
                if (group[i].getpointMin().X <= pointMin.X)
                {
                    pointMin.X = group[i].getpointMin().X;
                }

                if (group[i].getpointMin().Y <= pointMin.Y)
                {
                    pointMin.Y = group[i].getpointMin().Y;
                }


                if (group[i].getpointMax().X >= pointMax.X)
                {
                    pointMax.X = group[i].getpointMax().X;
                }


                if (group[i].getpointMax().Y >= pointMax.Y)
                {
                    pointMax.Y = group[i].getpointMax().Y;
                }
            }
        }

        public override void drawframe(Graphics gr)
        {
            findframe();
            gr.DrawRectangle(redPen, pointMin.X, pointMin.Y, pointMax.X - pointMin.X, pointMax.Y - pointMin.Y);
        }

        public override bool isGroup()
        {
            return true;
        }

        public override void save(StreamWriter stream)
        {
            stream.WriteLine("Group");
            stream.WriteLine(GetCount());
            for (int i = 0; i < GetCount(); i++)
                group[i].save(stream);
        }

        public override void load(StreamReader stream, AbstractFactory factory)
        {
            int k = Convert.ToInt32(stream.ReadLine());
            for (int i = 0; i < k; i++)
            {
                string t = stream.ReadLine();
                group.push_back(factory.createBase(t, width, height));
                group[i].load(stream, factory);
            }
            findframe();
        }
    }
}
