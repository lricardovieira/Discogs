using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace Discogs.Infra.Models
{

    public class Release 
    {
        public Release()
        {
        }


        public int Id { get; set; }

        public long InstanceId { get; set; }

        public DateTime  DateAdded { get; set; }

        public int Rating { get; set; }

        public BasicInformation BasicInformation { get; set; }
        
    }

    public class BasicInformation
    {
        public BasicInformation()
        {

        }
        public int  Id { get; set; }

        public long?  MasterId { get; set; }

        public string MasterUrl { get; set; }

        public string  Thumb { get; set; }

        public string CoverImage { get; set; }

        public string  Title { get; set; }

        public string  Year  { get; set; }

        public IReadOnlyList<Format> Formats { get; set; }
        
        public IReadOnlyList<Label> Labels { get; set; }

        public IReadOnlyList<Artist> Artists { get; set; }

        public IReadOnlyList<string> Genres { get; set; }

        public IReadOnlyList<string> Styles { get; set; }

        public BasicInformation(string year, int formatQuantity, int id, IReadOnlyList<string> style, string thumb, string title, IReadOnlyList<Label> label, long? masterId, IReadOnlyList<Format> format, IReadOnlyList<string> barcode, IReadOnlyList<string> genre, string country, string uri, IReadOnlyList<Format> formats, string coverImage)
        {
         
            Year = year;
            Id = id;
            Styles = style;
            Thumb = thumb;
            Title = title;
            Labels = label;
            MasterId = masterId;
            Formats = format;
           
            Genres = genre;

            MasterUrl = uri;
            Formats = formats;
            CoverImage = coverImage;
        }
    }


  






}
