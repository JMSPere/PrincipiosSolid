using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClosed.Correct
{
    /*
     * In this example, the class shape is an abstract class and each shape inherits from the former.
     * This facilitates the addition of new shapes to the code withou having to change anything from the already
     * written source code.
     */
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class  Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return 3.14 * Radius;
        }
    }
}
