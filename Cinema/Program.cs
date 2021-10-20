using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello cinema!");
            Cinema cinema = new("ERA");

            foreach (Movie movie in cinema)
            {
                Console.WriteLine(movie.Title);
            }

            cinema.Sort();

            Console.WriteLine("Sort by title\n");

            foreach (Movie movie in cinema)
            {
                Console.WriteLine(movie.Title);
            }

            Console.WriteLine("Sort by rating\n");

            cinema.Sort(new CompareByRating());
            foreach (Movie movie in cinema)
            {
                Console.WriteLine($"{movie.Title}->{movie.Rating}");
            }

            ////-----Clone-----
           
            Movie movie1 = new Movie("Eternals", "USA", 2020, 89, new Director("Chloe", "Zhao"),Genre.Adventure);
            Console.WriteLine($"\n{movie1}");

            Movie movie2 = (Movie)movie1.Clone();
            movie2.Rating = 100;
            Console.WriteLine($"\n{movie2}");
        }
    }
}
