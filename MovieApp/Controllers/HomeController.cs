using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustWatchApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Search(string q)
        {
            var allSeries = SeriesRepository.Series.Where(x => x.Name.ToLower().Contains(q.ToLower())).Select(x => new SearchModel { Id = x.Id, Name = x.Name, Description = x.ShortDescription, ImageUrl = x.ImageUrl, Status = x.Status }).ToList();
            var allMovies = MovieRepository.Movies.Where(x => x.Name.ToLower().Contains(q.ToLower())).Select(x => new SearchModel { Id = x.Id, Name = x.Name, Description = x.ShortDescription, ImageUrl = x.ImageUrl, Status = x.Status }).ToList();
            var list = allSeries.Union(allMovies).ToList();
            if (string.IsNullOrWhiteSpace(q))
                return View("Index");

            return View("List", list);
        }
        public IActionResult List()
        {
            return View();
        }
    }

}
