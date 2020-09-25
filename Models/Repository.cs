using System.Collections.Generic;
using System.Linq;

namespace CoreMvc.Models
{
    public static class Repository
    {
        private static List<Movie> _movies = null;

        static Repository()
        {
            _movies = new List<Movie>()
            {
                    new Movie (){ ID=1,Name="Shazam",Description="Shazam",ImageUrl="/wwwroot/img/shazam.jpg"},
                    new Movie (){ ID=2,Name="Amazing Grace",Description="Amazing Grace",ImageUrl="/wwwroot/img/amazingrace.jpg"},
                    new Movie (){ ID=3,Name="High Life",Description="High Life",ImageUrl="/wwwroot/img/highlife.jpg"},
                    new Movie (){ ID=4,Name="Avengers",Description="Avengers",ImageUrl="/wwwroot/img/avengers.jpg"},
                    new Movie (){ ID=5,Name="Atiye",Description="Atiye",ImageUrl="/wwwroot/img/atiye.jpg"},
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }


        public static Movie GetByID(int id)
        {
            return _movies.FirstOrDefault(i => i.ID == id);
        }
    }
}