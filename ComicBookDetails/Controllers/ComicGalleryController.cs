using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookDetails.Models;

namespace ComicBookDetails.Controllers
{
    public class ComicGalleryController:Controller
    {
        public object Role { get; private set; }

        public ActionResult Detail()
        {
            var ComicBook = new ComicBook()
            {
                SeriesName = "Half Girlfriend",
                IssueNumber = 700,
                DescriptionHtml = "<p>Chetan Bhagat published his first novel first novel 'Five Point Someone' in 2004 and this very first venture took him to the peaks of fame and popularity.The book depicted the story of an IIT student who considers himself to be below average than all the other students in IIT.</p>",
                Authors = new AuthorsMod[]
                {
                    new AuthorsMod() {Role="Author",Name="Chetan Bhagat"},
                    new AuthorsMod() {Role="Assosiate Writer",Name="Naga Deepika"},
                    new AuthorsMod() {Role="Chief Executive",Name="Bala Bhargav"},
                    new AuthorsMod() {Role="Editor Lineup",Name="Randeep Singh"},
                    new AuthorsMod() {Role="Producer",Name="Srinivas Rao"}
                }
            };
        return View(ComicBook);
        }   
    }
}