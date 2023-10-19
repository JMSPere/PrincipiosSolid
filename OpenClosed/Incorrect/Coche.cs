using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClosed.Incorrect
{
    public class Coche
    {
        String marca;

        public Coche(string marca) { this.marca = marca; }   

        public String GetMarcaCoche() { return marca; }
    }
}
