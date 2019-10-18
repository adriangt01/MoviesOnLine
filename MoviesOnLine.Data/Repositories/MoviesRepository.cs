using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesOnLine.Data.Entities;


namespace MoviesOnLine.Data.Repositories
{
    public class MoviesRepository
    {
        public List<Movies> getMovies()
        {
            using (var context = new MoviesDbContext())
            {
                return context.Movies.ToList();
            }

        }
        public int save(Movies movies)
        {
            using (var context = new MoviesDbContext())
            {
                context.Movies.Add(movies);
                

                return context.SaveChanges();
            }

        }
        public int save(Movies movies)
        {
            using (var context = new MoviesDbContext())
            {
                context.Movies.Add(movies);
                int id = movies.MoviesId;
                Movies newMoview = context.Movies.Find(id);

                return context.SaveChanges();
            }

        }
    }
}
