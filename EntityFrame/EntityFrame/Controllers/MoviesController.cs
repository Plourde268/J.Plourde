using EntityFrame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrame.Controllers
{
    public class MoviesController : Controller
    {
        //private class instance variable (or global class variable)
        private MovieDBContext _db = new MovieDBContext();
        // GET: Movies
        //Public Instance Method
        public ActionResult Index()
        {
            IQueryable<Movie> Movies = from m in _db.Movies select m;
            return View(Movies.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            Movie movie = _db.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if(ModelState.IsValid)
            {
                //Dont use this
                //_db.Entry(movie).State = System.Data.Entity.EntityState.Modified;

                Movie original = _db.Movies.Find(movie.Id);
                original.Title = movie.Title;
                original.Director = movie.Director;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

    }
}