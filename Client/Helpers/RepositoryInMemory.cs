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
                new Movie() { Title = "Spiderman returns", ReleaseDate = new DateTime(2019, 7, 2)},
                new Movie() { Title = "Harry and Sally", ReleaseDate = new DateTime(1988, 8, 16)},
                new Movie() { Title = "King Kong", ReleaseDate = new DateTime(1976, 11, 2)}

            };

        }
    }
}
