using Discogs.Infra.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Discogs.Infra.Extensions;

namespace Discogs.Infra.Repositories
{
    public sealed class DiscogsDatabaseApi
    {
        public readonly DiscogsApiEnvironment Environment;

        public DiscogsDatabaseApi(DiscogsApiEnvironment environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public async Task<ReleasesDto> Search()
        {
            var url = "https://api.discogs.com/users/ausamerika/collection/folders/0/releases".AsUrl();
            return await Environment.Get<ReleasesDto>(url).ConfigureAwait(false);
        }

    }
}
