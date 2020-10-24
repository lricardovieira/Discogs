using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Discogs.Infra.Models.Convert
{
      sealed class ResultConvert : JsonConverter
    {
        public override bool CanConvert(Type objectType) =>
            objectType == typeof(IRelease);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;

            var obj = JObject.Load(reader);
           
            return obj.ToObject<ReleasesDto>(serializer);

        }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }



    }
}
