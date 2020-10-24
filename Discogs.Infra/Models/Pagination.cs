using System;
using System.Collections.Generic;
using System.Text;

namespace Discogs.Infra.Models
{
    public class Pagination
    {
        public Pagination()
        {

        }

        public Pagination(int perPage, int pages, int page, PaginationUrls urls, int items)
        {
            PerPage = perPage;
            Pages = pages;
            Page = page;
            Urls = urls;
            Items = items;
        }
        public int Page { get; set; }

        public int Pages { get; set; }
        public int PerPage { get; set; }

        public int Items { get; set; }

        public PaginationUrls Urls { get; set; }
    

    }

  
}
