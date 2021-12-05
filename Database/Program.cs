using System;
using System.Collections.Generic;
using System.Linq;

namespace Database
{
    class Program
    {
        class Statistica
        {
            private readonly MyContext context;
            public Statistica()
            {
                context = new MyContext();
            }
            public IEnumerable<Artist> AllArttists()
            {
                return context.Artists.OrderBy(s => s.Name).ToList();
            }
            public IEnumerable<Tracks> TrackDuration()
            {
                return context.Tracks.ToList().OrderBy(s => s.Name).Where(t => t.Duration > 5);
            }

            public IEnumerable<Tracks> Trackon()
            {
                return context.Tracks.OrderBy(s => s.Duration).Where(t => t.Name == "Time");
            }
            public IEnumerable<Tracks> TrackToAlbumName()
            {
                return context.Tracks.OrderBy(n => n.Name).Where(y => y.Albums.Name.Equals("Fade"));
            }

            public IEnumerable<Tracks> TrackToTrackName()
            {
                var nameAlbum = context.Albums.ToList();
                string[] result = new string[200];
                int index = 0;
                int r = nameAlbum.Count();
                while(r>0)
                {
                    foreach (var item in nameAlbum)
                    {
                        string[] words = item.Name.Split(new char[] { ' ' });
                        for (int i = 0; i < words.Length; i++)
                        {
                            result[index++] = words[i];
                        }
                        r--;
                    }
                   
                }
                
                for (int g = 0; g < result.Length; g++)
                {
                    return context.Tracks.OrderBy(n => n.Name).Where(y => y.Name.Contains(result[5]));

                }

                return context.Tracks.ToList();
            }


        }
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            //DbSeeder.SeedDataBase(context);
            //DbSeeder.AddData(context);
            Statistica statistica = new();
            //var res= statistica.AllArttists();
            //var res = statistica.TrackToAlbumName();

            var res = statistica.TrackToTrackName();

            foreach (var item in res)
            {
                Console.WriteLine($"--{item.Name}--");

            }

        }
    }
}
