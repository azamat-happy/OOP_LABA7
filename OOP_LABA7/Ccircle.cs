using System;
using System.Collections.Generic;
using System.Drawing;
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
                gr.FillEllipse(Brushes.Gray, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
            else if (objcol == "LightSeaGreen")
            {
                gr.FillEllipse(Brushes.LightSeaGreen, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
            else if (objcol == "Orange")
            {
                gr.FillEllipse(Brushes.Orange, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
            else if (objcol == "Green")
            {
                gr.FillEllipse(Brushes.Green, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
            else if (objcol == "Yellow")
            {
                gr.FillEllipse(Brushes.Yellow, point.X - size, point.Y - size, 2 * size, 2 * size);
            }
        }

        public override void drawframe(Graphics gr)
        {
            gr.DrawEllipse(redPen, point.X - size, point.Y - size, 2 * size, 2 * size);
        }

        public override bool CheckIfObjectUnderCoordination(Point p)
        {
            return ((p.X - point.X) * (p.X - point.X) + (p.Y - point.Y) * (p.Y - point.Y) < size * size);
        }
    }
}
