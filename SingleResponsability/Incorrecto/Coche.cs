using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.SingleResponsability.Incorrecto
{
    //Esta clase no cumple ocn el principio de Single Responsability ya
    //que mezcla la funcionalidad de modelo de clase con la
    //funcionalidad de guardar un coche en la base de datos
    public class Coche
    {
        String marca;

        Coche(String marca) { this.marca = marca; }

        String getMarcaCoche() { return marca; }

        void guardarCocheDB(Coche coche)
        {

        }
    }
}
