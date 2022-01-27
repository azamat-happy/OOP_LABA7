using System.Drawing;

namespace OOP_LABA_6_1
{
    class AbstractFactory
    {
        public virtual BaseClass createBase(string code, int _width, int _height)
        {
            return null;
        } 
    }

    class MyFactory : AbstractFactory
    {
        public override BaseClass createBase(string code, int _width, int _height)
        {
            BaseClass obj = null;
            switch (code)
            {
                case "Circle":
                    obj = new CCircle(new Point(0,0));
                    break;
                case "Square":
                    obj = new Square(new Point(0, 0));
                    break;
                case "Section":
                    obj = new Section(new Point(0, 0));
                    break;
                case "Triangle":
                    obj = new Triangle(new Point(0, 0));
                    break;
                case "Group":
                    obj = new Group(_width, _height);
                    break;
                default:
                    break;
            }

            return obj;
        }
    }
}
