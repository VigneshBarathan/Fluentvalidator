using System;
using System.Linq;
using Fluentvalidator;

namespace Fluentvalidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Customermodel customermodel = new();
            customermodel.Name = "Vignesh";
            customermodel.Phone = "123456789";
            customermodel.Other = 1;
            CustomerWithFluentValidation(customermodel);
        }

        private static void CustomerWithFluentValidation(Customermodel customermodel)
        {
            var validator = new CustomerValidator();
            var validRes = validator.Validate(customermodel);
            if(!validRes.IsValid)
            {
                Console.WriteLine(validRes.Errors.FirstOrDefault());
            }
        }
    }
}
