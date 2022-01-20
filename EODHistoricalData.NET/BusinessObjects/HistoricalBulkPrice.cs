﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using EODHistoricalData.NET;
//
//    var historicalData = HistoricalData.FromJson(jsonString);

namespace EODHistoricalData.NET
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class HistoricalExchangePrice
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        
        [JsonProperty("exchange_short_name")]
        public string ExchangeShortName { get; set; }
        
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("open")]
        public double Open { get; set; }

        [JsonProperty("high")]
        public double High { get; set; }

        [JsonProperty("low")]
        public double Low { get; set; }

        [JsonProperty("close")]
        public double Close { get; set; }

        [JsonProperty("adjusted_close")]
        public double AdjustedClose { get; set; }

        [JsonProperty("volume")]
        public long Volume { get; set; }
    }

    public partial class HistoricalExchangePrice
    {
        public static HistoricalExchangePrice FromJson(string json) => JsonConvert.DeserializeObject<HistoricalExchangePrice>(json, EODHistoricalData.NET.ConverterHistoricalBulkPrice.Settings);

        public static List<HistoricalExchangePrice> GetListFromJson(string json) => JsonConvert.DeserializeObject<List<HistoricalExchangePrice>>(json, EODHistoricalData.NET.ConverterHistoricalBulkPrice.Settings);

    }

    public static class SerializeHistoricalBulkPrice
    {
        public static string ToJson(this HistoricalPrice self) => JsonConvert.SerializeObject(self, EODHistoricalData.NET.ConverterHistoricalBulkPrice.Settings);
    }

    internal static class ConverterHistoricalBulkPrice
    {
        public static List<string> Errors = new List<string>();
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal },
                new NullConverter(),
            },
            Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
            {
                Errors.Add(args.ErrorContext.Error.Message);
                args.ErrorContext.Handled = true;
            },
        };
    }
}
