using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookDetails.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesName { get; set; }
        public string DescriptionHtml { get; set; }
        public int IssueNumber { get; set; }
        public AuthorsMod[] Authors { get; set; }
        public bool Favourite { get; set; }


    }
}