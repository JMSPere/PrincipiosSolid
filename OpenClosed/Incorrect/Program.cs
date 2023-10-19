using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClosed.Incorrect
{
    public class Program
    {
        public static void main(String[] args)
        {
            Coche[] arrayCoches =
            {
                new Coche("Renault"),
                new Coche("Audi"),
            };
            imprimirPrecioMedioCoche(arrayCoches);
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach(Coche coche in arrayCoches)
            {
                if (coche.GetMarcaCoche().Equals("Renault")) Console.WriteLine(18000);
                if (coche.GetMarcaCoche().Equals("Audi")) Console.WriteLine(25000);
            }
        }
    }
}
