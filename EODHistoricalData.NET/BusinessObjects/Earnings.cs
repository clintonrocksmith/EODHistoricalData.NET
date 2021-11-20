﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using EODHistoricalData.NET;
//
//    var earnings = Earnings.FromJson(jsonString);

namespace EODHistoricalData.NET
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public partial class Earnings
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("from")]
        public DateTimeOffset? From { get; set; }

        [JsonPropertyName("to")]
        public DateTimeOffset? To { get; set; }

        [JsonPropertyName("earnings")]
        public List<Earning> EarningsData { get; set; }
    }

    public partial class Earning
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("report_date")]
        public DateTimeOffset? ReportDate { get; set; }

        [JsonPropertyName("date")]
        public string DateString { get; set; }

        [JsonPropertyName("actual")]
        public double? Actual { get; set; }

        [JsonPropertyName("estimate")]
        public double? Estimate { get; set; }

        [JsonPropertyName("difference")]
        public double Difference { get; set; }

        [JsonPropertyName("percent")]
        public double? Percent { get; set; }

        public DateTime? Date { get; set; }
    }

    public partial class Earnings
    {
        public static Earnings FromJson(string json)
        {
            Earnings result = JsonConvert.DeserializeObject<Earnings>(json, EODHistoricalData.NET.ConverterEarnings.Settings);
            foreach (Earning earning in result.EarningsData)
            {
                if (!earning.DateString.StartsWith("0000"))
                    earning.Date = DateTime.Parse(earning.DateString, CultureInfo.InvariantCulture);
            }
            return result;
        }
    }

    public static class SerializeEarnings
    {
        public static string ToJson(this Earnings self) => JsonConvert.SerializeObject(self, EODHistoricalData.NET.ConverterEarnings.Settings);
    }

    internal static class ConverterEarnings
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
