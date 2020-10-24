using System;
using System.Collections.Generic;
using System.Text;

namespace Discogs.Infra.Models
{
    public class Format
    {

        public Format()
        {

        }

        public string Name { get; set; }

        public string Qty { get; set; }

        public IReadOnlyList<string> Descriptions { get; set; }

        public Format(IReadOnlyList<string> descriptions, string name, string qty)
        {
            Descriptions = descriptions;
            Name = name;
            Qty = qty;
        }
    }
}

