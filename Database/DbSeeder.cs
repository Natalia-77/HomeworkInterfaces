using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class DbSeeder
    {
        public static void SeedDataBase(MyContext context)
        {
            if (!context.Artists.Any())
            {
                context.Artists.Add(
                        new Artist
                        {
                            Name = "Beyonce",
                            Surname = "Carter",
                            Country = "USA"
                        });
                context.Artists.Add(
                        new Artist
                        {
                            Name = "Thomas",
                            Surname = "Stewart",
                            Country = "Britain"
                        });
                context.Artists.Add(
                       new Artist
                       {
                           Name = "Demi",
                           Surname = "Lovato",
                           Country = "Mexico"
                       });
                context.SaveChanges();
            }

            if (!context.Albums.Any())
            {
                context.Albums.Add(
                    new Albums
                    {
                        Name = "I'm Sasha Fierse",
                        Genre = "RNB",
                        ArtistId = 1
                    });
                context.Albums.Add(
                    new Albums
                    {
                        Name = "Storm",
                        Genre = "RNB",
                        ArtistId = 2
                    });
                context.Albums.Add(
                   new Albums
                   {
                       Name = "Fade",
                       Genre = "RNB",
                       ArtistId = 3
                   });
                context.SaveChanges();
            }

            if (!context.Playlists.Any())
            {
                var play =
                 new Playlists()
                 {
                     Name = "Strong",
                     Category = "Work",

                 };
                context.Playlists.Add(play);
                context.SaveChanges();

                var tracks = new List<Tracks> {
                new Tracks
                {
                    Name = "Lost",
                    Duration = 10,
                    PlaylistId=play.Id,
                    AlbumId=1
                },
                new Tracks
                {
                    Name = "Stay",
                    Duration = 7,
                    PlaylistId=play.Id,
                    AlbumId=1
                },
                new Tracks
                {
                    Name = "Jump",
                    Duration = 6,
                    PlaylistId=play.Id,
                    AlbumId=1
                },
                new Tracks
                {
                    Name = "Run",
                    Duration = 4,
                    PlaylistId=play.Id,
                    AlbumId=1
                },
                new Tracks
                {
                    Name = "Stop",
                    Duration = 5,
                    PlaylistId=play.Id,
                    AlbumId=2
                },
                new Tracks
                {
                    Name = "Smile",
                    Duration = 8,
                    PlaylistId=play.Id,
                    AlbumId=3
                },
                new Tracks
                {
                    Name = "Read",
                    Duration = 3,
                    PlaylistId=play.Id,
                    AlbumId=3
                }
                };
                context.Tracks.AddRange(tracks);
                context.SaveChanges();
            }

        }


        public static void AddData(MyContext context)
        {

            Console.WriteLine("===Creating new playlist===");
            Console.WriteLine("Enter name of playlist:");
            string name_play = Console.ReadLine();
            Console.WriteLine("Enter category:");
            string categoty = Console.ReadLine();

            var playlist = new Playlists
            {
                Name = name_play,
                Category = categoty
            };
            context.Playlists.Add(playlist); ;
            context.SaveChanges();

            Console.WriteLine("Enter artist:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter counrty:");
            string country = Console.ReadLine();
            var artist= new Artist
                        {
                            Name = name,
                            Surname = surname,
                            Country = country
                        };
            context.Artists.Add(artist);
            context.SaveChanges();

            Console.WriteLine("Entername of album: ");
            string album = Console.ReadLine();
            Console.WriteLine("Enter genre:");
            string genre = Console.ReadLine();

            var albumnew = new Albums
            {
                Name = album,
                Genre = genre,
                ArtistId = artist.Id
            };
            context.Albums.Add(albumnew);
            context.SaveChanges();

            Console.WriteLine("Enter tracks:");
            string name_track = Console.ReadLine();
            Console.WriteLine("Enter duration:");
            int duration = int.Parse(Console.ReadLine());

            var track = new Tracks
            {
                Name = name_track,
                Duration = duration,
                PlaylistId=playlist.Id,
                AlbumId = albumnew.Id
            };
            context.Tracks.Add(track);
            context.SaveChanges();
        }
    }
}
