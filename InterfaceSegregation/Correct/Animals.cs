using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.InterfaceSegregation.Correct
{
    /*
     * In this example we can se how specific the given interfaces are, giving flexibility and reusability to the code while
     * only having to implement the necessary methods for each class.
     */
    public interface IEat
    {
        void Eat();
    }

    public interface ISleep
    {
        void Sleep();
    }

    public interface ISwim
    {
        void Swim();
    }

    public interface IFly
    {
        void Fly();
    }

    public class Fish : IEat, ISleep, ISwim
    {
        public void Eat() { /*...*/ }
        public void Sleep() {/*...*/}
        public void Swim() { /*...*/ }
    }

    public class Bird : IEat, ISleep, IFly
    {
        public void Eat() { /*...*/ }
        public void Sleep() { /*...*/ }
        public void Fly() { /*...*/ }
    }
}
