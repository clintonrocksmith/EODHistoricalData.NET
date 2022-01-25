﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using EODHistoricalData.NET;
//
//    var shareSplit = ShareSplit.FromJson(jsonString);

namespace EODHistoricalData.NET
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public partial class ShareSplit
    {
        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }

        [JsonPropertyName("split")]
        public string Split { get; set; }

        [JsonIgnore]
        public decimal BaseNumber { get; set; }

        [JsonIgnore]
        public decimal SplitFactor { get; set; }
    }

    public partial class ShareSplit
    {
        public static List<ShareSplit> FromJson(string json)
        {
            List<ShareSplit> splits = JsonSerializer.Deserialize<List<ShareSplit>>(json, EODHistoricalData.NET.ConverterShareSplit.Settings);
            foreach (ShareSplit split in splits)
            {
                string[] factors = split.Split.Split('/');
                split.SplitFactor = decimal.Parse(factors[0], CultureInfo.InvariantCulture);
                split.BaseNumber = decimal.Parse(factors[1], CultureInfo.InvariantCulture);
            }
            return splits;
        }
    }

    public static class SerializeShareSplit
    {
        public static string ToJson(this List<ShareSplit> self) => JsonSerializer.Serialize(self, EODHistoricalData.NET.ConverterShareSplit.Settings);
    }

    internal static class ConverterShareSplit
    {
        public static List<string> Errors = new List<string>();
        public static readonly JsonSerializerOptions Settings = new JsonSerializerOptions
        {
            // MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            // DateParseHandling = DateParseHandling.None,
            // Converters =
            // {
            //     new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal },
            //     new NullConverter(),
            // },
            // Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
            // {
            //     Errors.Add(args.ErrorContext.Error.Message);
            //     args.ErrorContext.Handled = true;
            // },
        };
    }
}
