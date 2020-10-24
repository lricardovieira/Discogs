using System;
using System.Collections.Generic;
using System.Text;

namespace Discogs.Infra.Models
{
    public class Label
    {
        public Label()
        {

        }

        public string Name { get; set; }

        public string Ctno { get; set; }

        public string EntityType { get; set; }

        public string EntityTypeName { get; set; }

        public int Id { get; set; }

        public string ResourceUrl { get; set; }

        public Label(string name, string entityType, string catno, string resourceUrl, int id, string entityTypeName)
        {
            Name = name;
            EntityType = entityType;
            ResourceUrl = resourceUrl;
            Id = id;
            EntityTypeName = entityTypeName;
        }

    }

}
