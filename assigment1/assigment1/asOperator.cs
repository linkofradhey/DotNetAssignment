using System;
using System.Collections.Generic;
using System.Text;

namespace assigment1
{
    class Customer
    {
        public string Name { get; set; }
    }

    class premiunCustomer : Customer
    {
        public int DiscountPercentage { get; set; }
    }

    class asOperator
    {


        static void Main()
        {
            Customer customer = new premiunCustomer
            {
                Name = "aaa",
                DiscountPercentage = 20
            };

            premiunCustomer pc = customer as  premiunCustomer;

            if (pc != null)// if they are   a premiun customer

            {

                Console.WriteLine($"{pc.Name} qualifies for a {pc.DiscountPercentage}% discount.");

            }

            else

            {

                Console.WriteLine("Customer does not qualify for a premium discount.");

            }
        }
    }
}
