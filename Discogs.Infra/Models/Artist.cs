using System;
using System.Collections.Generic;
using System.Text;

namespace Discogs.Infra.Models
{

    public class Artist
    {

        public string Name { get; set; }

        public string Anv { get; set; }

        public string Join { get; set; }

        public string Role { get; set; }

        public string Tracks { get; set; }

        public int Id { get; set; }

        public string ResourceUrl { get; set; }

        public Artist(string join, string name, string anv, string tracks, string role, string resourceUrl, int id)
        {
            Join = join;
            Name = name;
            Anv = anv;
            Tracks = tracks;
            Role = role;
            ResourceUrl = resourceUrl;
            Id = id;
        }
    }
}
