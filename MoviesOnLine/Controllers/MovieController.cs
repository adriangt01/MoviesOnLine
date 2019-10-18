using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesOnLine.Data.Entities;
using MoviesOnLine.Data.Repositories;
using MoviesOnLine.Helper;

namespace MoviesOnLine.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            MoviesRepository repository = new MoviesRepository();
            var list = repository.getMovies();
            var model = MapHelper.Map < IEnumerable<Models.MovieList> > (list);
            return View(model);

           // return View();
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Movies movies = new Movies();
                movies.Title = collection.Get("Title");
                movies.Director = collection.Get("Director");
                movies.Duration = float.Parse(collection.Get("Duracion"));
                movies.Year = int.Parse(collection.Get("Year"));


                MoviesRepository repository = new MoviesRepository();
                if (repository.save(movies) > 0)
                {
                    Console.WriteLine("ok");
                }
                else
                {
                    Console.WriteLine("no ok");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
