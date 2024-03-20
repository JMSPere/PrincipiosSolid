using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClosed.Incorrect
{
    /*
     * The following example does not implement the open/closed principle, 
     * because if another shape was to be added we would require to change
     * the already written code, instead of writing just a definition for a new shape 
     * separately.
     */
    public class Shape
    {
        public double Area()
        {
            if (this is Rectangle)
            {
                return (this as Rectangle).Width * (this as Rectangle).Height;
            }
            else if (this is Circle)
            {
                return 3.14 * (this as Circle).Radius * (this as Circle).Radius;
            }

            return 0;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
    }
}
