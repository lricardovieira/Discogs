using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Discogs.Infra.Models;
using Discogs.Infra.Models.Convert;
using Discogs.Infra.Repositories;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Discogs.Infra.Extensions
{
    static class DiscogsApiEnvironmentExtensions
    {

        static T DeserializeJson<T>(string json)
        {
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Converters = new JsonConverter[]
                {
                    new ResultConvert()
                }
            };
            return JsonConvert.DeserializeObject<T>(json, jsonSerializerSettings);
        }

        public static async Task<T> Get<T>(
            this DiscogsApiEnvironment environment,
            string url,
            CancellationToken cancellationToken = default
        )
        {
            var httpMessageInvoker = environment.HttpMessageInvoker;
            var resp = await httpMessageInvoker.SendAsync(
                new HttpRequestMessage(HttpMethod.Get, url),
                cancellationToken
            ).ConfigureAwait(false);
            var json = await resp.Content.ReadAsStringAsync().ConfigureAwait(false);

            var error = DeserializeJson<Error>(json);

            if (resp.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new DiscogsApiServerErrorException(error.Message);
            }

            if (resp.StatusCode == HttpStatusCode.NotFound)
            {
                throw new DiscorgsApiNotFoundException(error.Message);
            }

            if (error.Message != null)
            {
                if (error.Message == DiscogsApiQuotaException.ApiErrorMessage)
                {
                    throw new DiscogsApiQuotaException();
                }

                // TODO: rename the exception
                throw new DiscogsApiServerErrorException(error.Message);
            }

            return DeserializeJson<T>(json);
        }
    }
}
