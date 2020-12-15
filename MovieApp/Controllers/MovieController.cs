using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustWatchApplication.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index(int? id, int page = 1, int category = 0)
        {
            //int pageSize = 4;
            var movies = MovieRepository.Movies;
            //movies = MovieRepository.Movies.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            //ViewBag.PageCount = (int)Math.Ceiling(movies.Count() / (double)pageSize);
            //ViewBag.PageSize = pageSize;
            //ViewBag.CurrentPage = page;
            //ViewBag.CurrentCategory = category;

            if (id != null && id != 1)
            {
                //movies = (movies.Where(x => x.CategoryId == id).ToList()).Skip((page - 1) * pageSize).Take(pageSize).ToList();
                movies = movies.Where(x => x.CategoryId == id).ToList();
            }
            else if (id == 1)
            {
                //movies = MovieRepository.Movies.Skip((page - 1) * pageSize).Take(pageSize).ToList();
                movies = MovieRepository.Movies;
            }
            return View(movies);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }
        public IActionResult List()
        {
            return View();
        }

    }
}
