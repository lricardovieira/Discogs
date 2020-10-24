using System.Linq;
using Flurl;
using Flurl.Util;
using Newtonsoft.Json.Serialization;

namespace Discogs.Infra.Extensions
{
    static class UrlExtensions
    {
        public static Url AsUrl(this string str) => new Url(str);

        static readonly SnakeCaseNamingStrategy SnakeCaseNamingStrategy = new SnakeCaseNamingStrategy();
        static string ToSnakeCase(string str) =>
            SnakeCaseNamingStrategy.GetPropertyName(str, false);

        public static string AppendQueryParams(this Url url, object obj) => obj
            .ToKeyValuePairs()
            .Aggregate(url, (a, x) => a.SetQueryParam(
                ToSnakeCase(x.Key),
                x.Value?.GetType().IsEnum ?? false ? ToSnakeCase(x.Value.ToString()) : x.Value
            ));
    }
}
