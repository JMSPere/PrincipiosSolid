using PrincipiosSolid.LiskovSubstitution.Incorrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Incorrect
{
    /*
     * This example does not implement Liskov Substitution principle because the derived class Triangle changes the GetSides() 
     * method functionality. That's due to the fact that in this example we are assuming we can use the instantiation of Triangle the same way we could 
     * use an instantiation of Rectangle and this is not true in this scenario.
     */
    public class Rectangle
    {
        public virtual string GetSides()
        {
            return "4";
        }
    }

    public class Triangle : Rectangle
    {
        public override string GetSides()
        {
            return "3";
        }
    }

    /*
     * Rectangle rectangle = new Triangle();
     * Console.WriteLine(Rectangle.GetSides()); Shows "3" when it should show "4"
     */
}
