using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.SingleResponsability.Incorrecto
{
    /*
     * This class does not apply the Single Responsability principle.
     * That's because it would implement all of these: model class, validation
     * of the model and persistence of the class.
     */
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public bool Validate()
        {
            // Validates if the client is valid
            return false;
        }

        public void Save()
        {
            // Saves the client in the DB
        }
    }
}
