﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using EODHistoricalData.NET;
//
//    var incomingSplits = IncomingSplits.FromJson(jsonString);

namespace EODHistoricalData.NET
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public partial class IncomingSplits
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("from")]
        public DateTimeOffset From { get; set; }

        [JsonPropertyName("to")]
        public DateTimeOffset To { get; set; }

        [JsonPropertyName("splits")]
        public List<Split> Splits { get; set; }
    }

    public partial class Split
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("split_date")]
        public DateTimeOffset? SplitDate { get; set; }

        [JsonPropertyName("optionable")]
        public Optionable Optionable { get; set; }

        [JsonPropertyName("old_shares")]
        public long OldShares { get; set; }

        [JsonPropertyName("new_shares")]
        public long NewShares { get; set; }
    }

    public enum Optionable { N };

    public partial class IncomingSplits
    {
        public static IncomingSplits FromJson(string json) => JsonSerializer.Deserialize<IncomingSplits>(json, EODHistoricalData.NET.ConverterIncomingSplits.Settings);
    }

    public static class SerializeIncomingSplits
    {
        public static string ToJson(this IncomingSplits self) => JsonSerializer.Serialize(self, EODHistoricalData.NET.ConverterIncomingSplits.Settings);
    }

    internal static class ConverterIncomingSplits
    {
        public static List<string> Errors = new List<string>();
        public static readonly JsonSerializerOptions Settings = new JsonSerializerOptions
        {
            // MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            // DateParseHandling = DateParseHandling.None,
            // Converters =
            // {
            //     OptionableConverter.Singleton,
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

    // public class OptionableConverter : JsonConverter
    // {
    //     public OptionableConverter() : base()
    //     {
    //         
    //     }
    //     
    //     public override bool CanConvert(Type t) => t == typeof(Optionable) || t == typeof(Optionable?);
    //
    //     // public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     // {
    //     //     if (reader.TokenType == JsonToken.Null) return null;
    //     //     var value = serializer.Deserialize<string>(reader);
    //     //     if (value == "N")
    //     //     {
    //     //         return Optionable.N;
    //     //     }
    //     //     throw new Exception("Cannot unmarshal type Optionable");
    //     // }
    //
    //     // public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     // {
    //     //     if (untypedValue == null)
    //     //     {
    //     //         serializer.Serialize(writer, null);
    //     //         return;
    //     //     }
    //     //     var value = (Optionable)untypedValue;
    //     //     if (value == Optionable.N)
    //     //     {
    //     //         serializer.Serialize(writer, "N");
    //     //         return;
    //     //     }
    //     //     throw new Exception("Cannot marshal type Optionable");
    //     // }
    //
    //     public static readonly OptionableConverter Singleton = new OptionableConverter();
    // }
}
