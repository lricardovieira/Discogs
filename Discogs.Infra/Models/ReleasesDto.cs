using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Discogs.Infra.Models
{
    public sealed class ReleasesDto
    {
        public Pagination Pagination { get; set; }

        public IReadOnlyList<Release> Releases { get; set; }

        public ReleasesDto(Pagination pagination,
        IReadOnlyList<Release> releases)
        {
            Pagination = pagination;
            Releases = releases;
        }
}
}
