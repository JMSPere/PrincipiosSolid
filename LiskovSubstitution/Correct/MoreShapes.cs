using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Correct
{
    /*
     * In the following example we use the IShape interface, which defines a method called GetSides(). 
     * Both classes Triangle and Rectangle implement this interface and have its own implementation fo the GetSides() method.
     */
    public interface IShape
    {
        string GetSides();
    }

    public class Rectangle : IShape
    {
        public string GetSides()
        {
            return "4";
        }
    }

    public class Triangle : IShape
    {
        public string GetSides()
        {
            return "3";
        }
    }

    /*
     * IShape shape = new Triangle();
     * Console.WriteLine(shape.GetSides()); Shows "3"
     * shape = new Rectangle();
     * Console.WriteLine(shape.GetSides()); Shows "4"
     */
}
