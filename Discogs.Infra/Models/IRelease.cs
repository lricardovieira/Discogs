using System;
using System.Collections.Generic;
using System.Text;

namespace Discogs.Infra.Models
{
    public interface IRelease
    {
        int Id { get; }
        string Uri { get; }
        string Title { get; }
        string CoverImage { get; }
    }
}
