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
            //InitialiseCustomers(context);
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
                    LastName = "Smith"
                }
            };
        }
    }
}
