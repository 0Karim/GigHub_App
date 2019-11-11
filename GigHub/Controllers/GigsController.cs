using GigHub.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            GigViewModel model = new GigViewModel
            {
                Genres = _context.Genre.ToList()
            };
            return View(model);
        }


        [Authorize]
        [HttpPost]
        public ActionResult AddGig(GigViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Genres = _context.Genre.ToList();
                return View("Create", model);
            }

            Gig gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = model.DateTime,
                Venue = model.Venue,
                GenreId = model.GenreId
            };

            _context.Gig.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("Index" , "Home");
        }
    }
}