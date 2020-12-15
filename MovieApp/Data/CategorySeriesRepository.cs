using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public static class CategorySeriesRepository
    {
        private static List<CategorySeries> _categorySeries = null;
        static CategorySeriesRepository()
        {
            _categorySeries = new List<CategorySeries>()
            {
             new CategorySeries(){ Id=1, Name="List All"},
             new CategorySeries(){ Id=2, Name="Comedy"},
             new CategorySeries(){ Id=3, Name="Historical"},
             new CategorySeries(){ Id=4, Name="Horror"}
            };
        }
        public static List<CategorySeries> CategoriesSeries
        {
            get
            {
                return _categorySeries;
            }
        }
        public static void AddCategoriesSeries(CategorySeries series)
        {
            _categorySeries.Add(series);
        }
        public static CategorySeries GetById(int id)
        {
            return _categorySeries.FirstOrDefault(x => x.Id == id);
        }
    }
}




