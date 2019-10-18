using MoviesOnLine.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesOnLine.Data.Repositories
{
    public class MoviesDbContext:DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        public string movie;
        public string getMovies()
        {
            return movie;

        }
            
   

        
    }
}
