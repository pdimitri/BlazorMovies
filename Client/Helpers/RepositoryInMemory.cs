using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory: IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() { Title = "Spiderman returns", ReleaseDate = new DateTime(2019, 7, 2), 
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjIxYWU1YjEtZTQ5OC00YTY0LThhMmYtNzBlNGZkNzdkNjc2XkEyXkFqcGdeQXVyNjMxNzQ2NTQ@._V1_SY1000_SX1000_AL_.jpg" },
                new Movie() { Title = "Harry and Sally", ReleaseDate = new DateTime(1988, 8, 16),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjE0ODEwNjM2NF5BMl5BanBnXkFtZTcwMjU2Mzg3NA@@._V1_SY1000_CR0,0,666,1000_AL_.jpg"},
                new Movie() { Title = "King Kong", ReleaseDate = new DateTime(1976, 11, 2),
                    Poster="https://m.media-amazon.com/images/M/MV5BMjYxYmRlZWYtMzAwNC00MDA1LWJjNTItOTBjMzlhNGMzYzk3XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_CR0,0,675,1000_AL_.jpg"}

            };

        }
    }
}
