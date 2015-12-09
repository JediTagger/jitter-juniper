using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jitter.Models;

namespace Jitter.Controllers
{
    public class JitterController : Controller
    {
        public JitterRepository Repo { get; set; }

        public JitterController() : base()
        {
            Repo = new JitterRepository();
        }

        // GET: Jitter
        // Public feed at Index
        public ActionResult Index()
        {
            List<Jot> my_jots = Repo.GetAllJots();
            
            /*
            this is to test - example of how to inject information
            List<Jot> my_jots = new List<Jot>();
            my_jots.Add(new Jot { Content = "Yay!", Date = DateTime.Now });
            my_jots.Add(new Jot { Content = "Yay!", Date = DateTime.Now });
            my_jots.Add(new Jot { Content = "Yay!", Date = DateTime.Now });
            my_jots.Add(new Jot { Content = "Yay!", Date = DateTime.Now });
            */

            return View(my_jots);
        }

        [Authorize]
        public ActionResult TopFavs()
        {
            return View();
        }

        [Authorize]
        public ActionResult YourFeed()
        {
            ApplicationUserManager _userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            string userId = User.Identity.GetUserId();
            List<Jot> list_of_jots = Repo.GetUserJots();
            return View();
        }

        // GET: Jitter/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jitter/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jitter/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Jitter/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jitter/Edit/5
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

        // GET: Jitter/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Jitter/Delete/5
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
