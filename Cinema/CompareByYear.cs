using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class CompareByYear : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }
}
