using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class SearchMovieSeriesModel
    {
        public Series AllSeries { get; set; }
        public Movie AllMovies { get; set; }
        public IEnumerable<Series> Series { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
