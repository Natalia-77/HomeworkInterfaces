using System;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            DbSeeder.SeedDataBase(context);
            DbSeeder.AddData(context);
        }
    }
}
