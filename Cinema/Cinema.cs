using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema:IEnumerable
    {
        private Movie[] movies;
        private string _address;
        public Cinema(string address)
        {
            _address = address;

            movies = new Movie[3]
            {
                new Movie()
                {
                    Title="Duna",
                    Country="USA,Britain",
                    Year=2021,
                    Rating=25,
                    Director=new Director("Tom","Cruse"),
                    Genre=Genre.Adventure
                    
                },
                new Movie()
                {
                    Title="Back to the future",
                    Country="USA",
                    Year=1985,
                    Rating=80,
                     Director=new Director("Harrison","Ford"),
                    Genre=Genre.Adventure
                   
                },
                 new Movie()
                 {
                    Title="No time to die",
                    Country="USA",
                    Year=2020,
                    Rating=100,
                    Director=new Director("Cary","Fukunaga"),
                    Genre=Genre.Adventure
                   
                 }
            };

        }

        public IEnumerator GetEnumerator()
        {
            return movies.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(movies);
        }

        public void Sort(IComparer<Movie> comparer)
        {
            Array.Sort(movies, comparer);
        }

    }
}
