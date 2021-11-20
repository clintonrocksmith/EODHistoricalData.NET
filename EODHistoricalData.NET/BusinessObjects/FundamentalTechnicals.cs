using System.Text.Json;

namespace EODHistoricalData.NET.BusinessObjects
{
    public class FundamentalTechnicals
    {
        [JsonPropertyName("Beta")]
        public decimal? Beta { get; set; }

        [JsonPropertyName("52WeekHigh")]
        public decimal? The52WeekHigh { get; set; }

        [JsonPropertyName("52WeekLow")]
        public decimal? The52WeekLow { get; set; }

        [JsonPropertyName("50DayMA")]
        public decimal? The50DayMa { get; set; }

        [JsonPropertyName("200DayMA")]
        public decimal? The200DayMa { get; set; }

        [JsonPropertyName("SharesShort")]
        public decimal? SharesShort { get; set; }

        [JsonPropertyName("SharesShortPriorMonth")]
        public decimal? SharesShortPriorMonth { get; set; }

        [JsonPropertyName("ShortRatio")]
        public decimal? ShortRatio { get; set; }

        [JsonPropertyName("ShortPercent")]
        public decimal? ShortPercent { get; set; }
    }
}
