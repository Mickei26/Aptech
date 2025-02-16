using System;
using System.Data.Entity;

namespace EAP_C1809L_DamKhoiNguyen.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.Genres.Add(new Genre() { GenreId = 1, GenreName = "Pop" });
            context.Genres.Add(new Genre() { GenreId = 2, GenreName = "Rock" });
            context.Genres.Add(new Genre() { GenreId = 3, GenreName = "Hip Hop" });
            context.Genres.Add(new Genre() { GenreId = 4, GenreName = "Jazz" });
            context.Genres.Add(new Genre() { GenreId = 5, GenreName = "Punk" });
            context.Genres.Add(new Genre() { GenreId = 6, GenreName = "Rap" });
            context.Genres.Add(new Genre() { GenreId = 7, GenreName = "R&B" });
            context.Genres.Add(new Genre() { GenreId = 8, GenreName = "Country" });
            context.Genres.Add(new Genre() { GenreId = 9, GenreName = "Latin" });

            context.Albums.Add(new Album() { AlbumId = 01, Title = "Twenty File", ReleaseDate = DateTime.Parse("2015-11-20"), Artist = "Adele", GenreId = 1, Price = 9.99 });
            context.Albums.Add(new Album() { AlbumId = 02, Title = "Nineteen Eighty-Nine", ReleaseDate = DateTime.Parse("2014-10-27"), Artist = "Taylor Swift", GenreId = 1, Price = 10.99 });
            context.Albums.Add(new Album() { AlbumId = 03, Title = "A million", ReleaseDate = DateTime.Parse("2016-09-30"), Artist = "Bon Iver", GenreId = 2, Price = 9.99 });
            context.Albums.Add(new Album() { AlbumId = 04, Title = "Meteora", ReleaseDate = DateTime.Parse("2003-03-25"), Artist = "Linkin Park", GenreId = 2, Price = 7.99 });
            context.Albums.Add(new Album() { AlbumId = 05, Title = "Nevermind", ReleaseDate = DateTime.Parse("1991-09-24"), Artist = "Nivarna", GenreId = 2, Price = 9.99 });
            context.Albums.Add(new Album() { AlbumId = 06, Title = "To Pimp a Butterfly", ReleaseDate = DateTime.Parse("2015-03-15"), Artist = "Kendrick Lamar", GenreId = 3, Price = 8.99 });
            context.Albums.Add(new Album() { AlbumId = 07, Title = "The Chronic", ReleaseDate = DateTime.Parse("1992-12-15"), Artist = "Dr.Dre", GenreId = 3, Price = 9.99 });
            context.Albums.Add(new Album() { AlbumId = 08, Title = "Comes Away With Me", ReleaseDate = DateTime.Parse("2002-02-26"), Artist = "Norah Jones", GenreId = 4, Price = 6.99 });
            context.Albums.Add(new Album() { AlbumId = 09, Title = "Kind of Blues", ReleaseDate = DateTime.Parse("1959-08-17"), Artist = "Miles Davids", GenreId = 4, Price = 7.99 });
            context.Albums.Add(new Album() { AlbumId = 10, Title = "Dookie", ReleaseDate = DateTime.Parse("1994-02-01"), Artist = "Green Day", GenreId = 5, Price = 8.99 });
            context.Albums.Add(new Album() { AlbumId = 11, Title = "Relapse", ReleaseDate = DateTime.Parse("2009-05-15"), Artist = "Eminem", GenreId = 6, Price = 9.99 });
            context.Albums.Add(new Album() { AlbumId = 12, Title = "Get Rich or Die", ReleaseDate = DateTime.Parse("2003-02-06"), Artist = "Tryin", GenreId = 6, Price = 7.99 });
            context.Albums.Add(new Album() { AlbumId = 13, Title = "Blonde", ReleaseDate = DateTime.Parse("2016-08-20"), Artist = "Frank Oceans", GenreId = 7, Price = 8.99 });
            context.Albums.Add(new Album() { AlbumId = 14, Title = "Love, Marriage & Divorce", ReleaseDate = DateTime.Parse("2014-02-04"), Artist = "Babyface & Toni Braxton", GenreId = 7, Price = 9.99 });
            context.Albums.Add(new Album() { AlbumId = 15, Title = "Lemonade", ReleaseDate = DateTime.Parse("2016-04-23"), Artist = "Beyonce", GenreId = 1, Price = 11.99 });
            context.Albums.Add(new Album() { AlbumId = 16, Title = "Purpose", ReleaseDate = DateTime.Parse("2015-11-13"), Artist = "Justin Bieber", GenreId = 1, Price = 9.99 });
            context.Albums.Add(new Album() { AlbumId = 17, Title = "Los Duo", ReleaseDate = DateTime.Parse("2015-02-10"), Artist = "Joan Gabriel", GenreId = 9, Price = 7.99 });
            context.Albums.Add(new Album() { AlbumId = 18, Title = "They Don’t KNow", ReleaseDate = DateTime.Parse("2016-09-09"), Artist = "Jason Aldean", GenreId = 9, Price = 9.99 });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}


