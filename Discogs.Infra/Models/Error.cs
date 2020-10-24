using System;
using System.Collections.Generic;
using System.Text;

namespace Discogs.Infra.Models
{
    public sealed class Error
    {
        public string Message { get; }

        public Error(string message)
        {
            Message = message;
        }
    }
}
