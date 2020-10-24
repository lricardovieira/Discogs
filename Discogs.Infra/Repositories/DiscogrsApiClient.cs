using System;
using System.Collections.Generic;
using System.Text;

namespace Discogs.Infra.Repositories
{
    public sealed class DiscogsApiClient
    {
        public readonly DiscogsApiEnvironment Environment;
        public DiscogsDatabaseApi Database => new DiscogsDatabaseApi(Environment);
    

        public DiscogsApiClient(DiscogsApiEnvironment environment)
        {
            Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public static DiscogsApiClient Create(DiscogsApiEnvironment environment) =>
            new DiscogsApiClient(environment);
    }
}
