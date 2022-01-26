using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LABA7
{
    class Square : BaseClass
    {
        public Square(Point coordination)
        {
            point = coordination;
        }


        override public void draw(Graphics gr, BaseClass obj)
        {
            string objcol = obj.getcolor();
            if (objcol == "Gray")
            {
                gr.FillRectangle(Brushes.Gray, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
            else if (objcol == "LightSeaGreen")
            {
                gr.FillRectangle(Brushes.LightSeaGreen, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
            else if (objcol == "Orange")
            {
                gr.FillRectangle(Brushes.Orange, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
            else if (objcol == "Green")
            {
                gr.FillRectangle(Brushes.Green, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
            else if (objcol == "Yellow")
            {
                gr.FillRectangle(Brushes.Yellow, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
        }

        override public void drawframe(Graphics gr)
        {
            gr.DrawRectangle(redPen, point.X - size, point.Y - size, 2 * size, 2 * size);
        }
        override public bool CheckIfObjectUnderCoordination(Point p)
        {
            if ((p.X > point.X - size) && (p.Y > point.Y - size) && (p.X < point.X + size) && (p.Y < point.Y + size))
            {
                return true;
            }
            else return false;
        }
    }
}
