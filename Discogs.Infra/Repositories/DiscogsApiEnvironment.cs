using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Discogs.Infra.Repositories
{
    public sealed class DiscogsApiEnvironment
    {
        public readonly HttpMessageInvoker HttpMessageInvoker;

        public DiscogsApiEnvironment( HttpMessageInvoker httpMessageInvoker)
        {
            HttpMessageInvoker = httpMessageInvoker ?? throw new ArgumentNullException(nameof(httpMessageInvoker));
        }


        public static DiscogsApiEnvironment CreateDefault()
        {

            var httpClient = new HttpClient { BaseAddress = new Uri("https://api.discogs.com/users/ausamerika/collection/folders/0/releases") };
            var headers = httpClient.DefaultRequestHeaders;
            headers.Add("User-Agent", "DiscogsAPI");

            return new DiscogsApiEnvironment( httpClient);
        }

    }
}
