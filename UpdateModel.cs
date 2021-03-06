// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QRCreator;
//
//    var updateModel = UpdateModel.FromJson(jsonString);

namespace QRCreator
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class UpdateModel
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("download_url")]
        public Uri DownloadUrl { get; set; }
    }

    public partial class UpdateModel
    {
        public static UpdateModel FromJson(string json) => JsonConvert.DeserializeObject<UpdateModel>(json, QRCreator.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this UpdateModel self) => JsonConvert.SerializeObject(self, QRCreator.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
