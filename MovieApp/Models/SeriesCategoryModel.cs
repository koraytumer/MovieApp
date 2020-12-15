using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class SeriesCategoryModel
    {
        public Series Serie { get; set; }
        public IEnumerable<Series> Series { get; set; }
        public IEnumerable<CategorySeries> Categories { get; set; }
    }
}
