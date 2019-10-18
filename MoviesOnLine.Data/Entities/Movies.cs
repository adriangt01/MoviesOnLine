using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesOnLine.Data.Entities
{
    public class Movies
    {
        public int MoviesId { get; set; }
        public string Title { get; set; }


       
        public float Duration { get; set; }
        
        public int Year { get; set; }
        
        public string Director { get; set; }
    }
}
