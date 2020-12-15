using MovieApp.Models;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public static class CategoryMovieRepository
    {
        private static List<CategoryMovie> _categoryMovie = null;
        static CategoryMovieRepository()
        {
            _categoryMovie = new List<CategoryMovie>()
            {
             new CategoryMovie(){ Id=1, Name="List All"},
             new CategoryMovie(){ Id=2, Name="Action"},
             new CategoryMovie(){ Id=3, Name="Comedy"},
             new CategoryMovie(){ Id=4, Name="Drama"},
             new CategoryMovie(){ Id=5, Name="Animation"},
             new CategoryMovie(){ Id=6, Name="Mystery"}
            };
        }
        public static List<CategoryMovie> CategoriesMovie
        {
            get
            {
                return _categoryMovie;
            }
        }
        public static void AddCategoriesMovie(CategoryMovie movie)
        {
            _categoryMovie.Add(movie);
        }
        public static CategoryMovie GetById(int id)
        {
            return _categoryMovie.FirstOrDefault(x => x.Id == id);
        }
    }
}




