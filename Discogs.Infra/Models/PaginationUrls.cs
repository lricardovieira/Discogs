using System;
using System.Collections.Generic;
using System.Text;

namespace Discogs.Infra.Models
{
    public class PaginationUrls
    {
        public PaginationUrls()
        {

        }
        public PaginationUrls(string last, string next)
        {
            Last = last;
            Next = next;
        }
        public string Last { get; set; }

        public string Next { get; set; }
    }
}
