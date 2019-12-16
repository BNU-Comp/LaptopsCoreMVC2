using LaptopsCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopsCoreMVC.Data
{
    public static class DbInitialiser
    {
        public static void DbInitialise(ApplicationDbContext context)
        {
            InitialiseCustomers(context);
        }

        private static void InitialiseCustomers(ApplicationDbContext context)
        {
            if(context.Customers.Any())
            {
                return;
            }

            var customers = new Customer[]
            {
                new Customer
                {
                    FirstName = "John",
                    LastName = "Smith",
                    EmailAddress = "Customer1@gmail.com",
                    PhoneNumber = "01639526487"


                },

                new Customer
                {
                    FirstName = "Mike",
                    LastName = "Johnson",
                    EmailAddress = "Customer2@gmail.com",
                    PhoneNumber = "01689576487"


                },

                new Customer
                {
                    FirstName = "Richard",
                    LastName = "Jones",
                    EmailAddress = "Customer3@gmail.com",
                    PhoneNumber = "01689573287"


                },

                new Customer
                {
                    FirstName = "Terry",
                    LastName = "Philips",
                    EmailAddress = "Customer4@gmail.com",
                    PhoneNumber = "01689576492"


                },

                new Customer
                {
                    FirstName = "Justin",
                    LastName = "Johnson",
                    EmailAddress = "Customer5@gmail.com",
                    PhoneNumber = "01689176487"


                },

                new Customer
                {
                    FirstName = "Johnny",
                    LastName = "Lazar",
                    EmailAddress = "Customer6@gmail.com",
                    PhoneNumber = "01689139587"


                },

                new Customer
                {
                    FirstName = "Jon",
                    LastName = "Bones",
                    EmailAddress = "Customer7@gmail.com",
                    PhoneNumber = "01689176403"


                },
                
                new Customer
                {
                    FirstName = "Jenny",
                    LastName = "Robertson",
                    EmailAddress = "Customer8@gmail.com",
                    PhoneNumber = "01680576487"


                },

                new Customer
                {
                    FirstName = "Rick",
                    LastName = "Johnson",
                    EmailAddress = "Customer9@gmail.com",
                    PhoneNumber = "01689173387"


                },
                
                new Customer
                {
                    FirstName = "Michael",
                    LastName = "Williams",
                    EmailAddress = "Customer10@gmail.com",
                    PhoneNumber = "01689176487"


                },

            };

            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }

            context.SaveChanges();

        }
    }
}
