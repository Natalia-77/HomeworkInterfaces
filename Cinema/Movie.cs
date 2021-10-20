using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public enum Genre { Drama, Horror, Comedy, Adventure };
    class Movie:IComparable<Movie>,ICloneable
    {
        public string Title { get; set; }       
        public string Country { get; set; }
        public int Year { get; set; }
        public short Rating { get; set; }
        public Director Director { get; set; }
        public Genre Genre { get; set; }
        public Movie()
        {

        }

        public Movie(string title,string country,int year,short rating,Director director,Genre genre)
        {
            Title = title;
            Country = country;
            Year = year;
            Rating = rating;
            Director = director;
            Genre = genre;

        }
        public object Clone()
        {
           
            Movie copymovie = (Movie)MemberwiseClone();            
            copymovie.Title = (string)Title.Clone();
            copymovie.Country = (string)Country.Clone();
            copymovie.Director = (Director)Director.Clone();

            return copymovie;
        }

        public int CompareTo(Movie other)
        {
            return this.Title.CompareTo(other.Title);
        }

        
        public override string ToString()
        {
            return $"Title of movie:{Title}\nDirector:{Director}\nYear prod.:{Year}\nGenre:{Genre}\nRate:{Rating}";
        }
    }
}
