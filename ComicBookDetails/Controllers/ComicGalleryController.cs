using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookDetails.Controllers
{
    public class ComicGalleryController:Controller
    {
        public ActionResult Detail()
        {
            ViewBag.Name = "Half Girlfriend";
            ViewBag.BookPrice = 700;
            ViewBag.BookDescription = "<p>Chetan Bhagat published his first novel first novel 'Five Point Someone' in 2004 and this very first venture took him to the peaks of fame and popularity. The book depicted the story of an IIT student who considers himself to be below average than all the other students in IIT.</p>";
            ViewBag.Authors = new string[]
            {
        "Chetan Bhagat:Author",
        "Naga Deepika: Assosiate Writer",
        "Bala Bhargav: Chief Executive",
        "Randeep Singh: Editor Lineup",
        "Srinivas Rao:Producer Of Book"

            };

            return View();
        }   
    }
}