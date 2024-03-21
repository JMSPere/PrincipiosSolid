using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.InterfaceSegregation.Incorrect
{
    /*
     * In this code we can see how the Animals interface has four methods. In certain scenarios this means it has to many methods, which will cause the classes 
     * implementing this interface will be forced to implement each method even if the class doesn't need it or shouldn't do it, resulting in useless methods for 
     * some classes.
     */
    public interface IAnimals
    {
        void Eat();
        void Sleep();
        void Swim();
        void Fly();
    }

    public class Fish : IAnimals
    {
        public void Eat()
        {
            // Code for Eat
        }

        public void Fly()
        {
            throw new NotImplementedException(); // A fish can't fly
        }

        public void Sleep()
        {
            // Code for sleep
        }

        public void Swim()
        {
            // Code for swim
        }
    }
}
