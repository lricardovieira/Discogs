using System;
using System.Collections.Generic;
using System.Text;

namespace Discogs.Infra.Models
{
    public abstract class DiscogsApiException : Exception
    {
        public DiscogsApiException(string message) : base(message) { }
    }

    public sealed class DiscogsApiQuotaException : DiscogsApiException
    {
        public const string ApiErrorMessage = "You are making requests too quickly.";
        public DiscogsApiQuotaException() : base(ApiErrorMessage) { }
    }

    public sealed class DiscogsApiServerErrorException : DiscogsApiException
    {
        public DiscogsApiServerErrorException(string apiMessage) : base(apiMessage) { }
    }

    public sealed class DiscorgsApiNotFoundException : DiscogsApiException
    {
        public DiscorgsApiNotFoundException(string apiMessage) : base(apiMessage) { }
    }
}
