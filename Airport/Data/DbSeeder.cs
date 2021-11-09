using Airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Data
{
    public static class DbSeeder
    {
        public static void SeedData(MyContext context)
        {
            if (!context.Accounts.Any())
            {
                context.Accounts.Add(
                        new Accounts
                        {
                            Login = "Ola",
                            Password = "123"
                        });
                context.Accounts.Add(
                       new Accounts
                       {
                           Login = "Molly",
                           Password = "123"
                       });
                context.Accounts.Add(
                       new Accounts
                       {
                           Login = "Kris",
                           Password = "123"
                       });
                context.SaveChanges();
            }

            if (!context.Flights.Any())
            {
                var fly = new Flights
                {
                    Number = 3256,
                    DepartDate = new DateTime(2021, 12, 12),
                    ArrivDate = new DateTime(2021, 12, 13),
                    DepartCity = "New York",
                    ArrivCity = "Paris"

                };
                context.Flights.Add(fly);
                context.SaveChanges();
            }






        }
    }
}
