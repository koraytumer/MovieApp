using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index(int? id)
        {
            var series = SeriesRepository.Series;
            if (id != null && id != 1)
            {
                series = series.Where(x => x.CategoryId == id).ToList();
            }
            else if (id == 1)
            {
                series = SeriesRepository.Series;
            }
            return View(series);
        }
        public IActionResult Details(int id)
        {
            return View(SeriesRepository.GetById(id));
        }
        public IActionResult Create()
        {
            return View();
        }

    }
}
