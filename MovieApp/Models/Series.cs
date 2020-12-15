using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Stars { get; set; }
        public string Director { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int Status { get; set; }
    }
}
