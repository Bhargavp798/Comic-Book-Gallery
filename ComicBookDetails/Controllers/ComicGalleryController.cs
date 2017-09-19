using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookDetails.Controllers
{
    public class ComicGalleryController:Controller
    {
        public ContentResult Detail()
        {
            return new ContentResult()
            {
                Content = "Hello Mvc Project"
            };
        }
    }
}