using System;

namespace PrincipiosSolid.SingleResponsability.Correcto
{
    /*
     *Decoupled version: model
     *This is shown in the same .cs file for educational purposes.
     *Some development styles may require each class to be in a different file.
     */
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class  CustomerRepository
    {
        public void Save(Customer customer)
        {
            // Saves the customer in the DB
        }
    }

    public class CustomerValidator
    {
        public bool Validate(Customer customer)
        {
            // Validates if the customer is valid
            return true;
        }
    }
}
