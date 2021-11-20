using System.Text.Json;
using System;

namespace EODHistoricalData.NET.BusinessObjects
{
    public class FundamentalGeneral
    {
        [JsonPropertyName("Code")]
        public string Code { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Exchange")]
        public string Exchange { get; set; }

        [JsonPropertyName("CurrencyCode")]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("CurrencyName")]
        public string CurrencyName { get; set; }

        [JsonPropertyName("CurrencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("CountryName")]
        public string CountryName { get; set; }

        [JsonPropertyName("CountryISO")]
        public string CountryIso { get; set; }

        [JsonPropertyName("ISIN")]
        public string Isin { get; set; }

        [JsonPropertyName("CUSIP")]
        public string Cusip { get; set; }

        [JsonPropertyName("Fund_Summary")]
        public string FundSummary { get; set; }

        [JsonPropertyName("Fund_Family")]
        public string FundFamily { get; set; }

        [JsonPropertyName("Fiscal_Year_End")]
        public string FiscalYearEnd { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Category")]
        public string Category { get; set; }

        [JsonPropertyName("CIK")]
        public string Cik { get; set; }

        [JsonPropertyName("EmployerIdNumber")]
        public string EmployerIdNumber { get; set; }

        [JsonPropertyName("IPODate")]
        public DateTimeOffset? IpoDate { get; set; }

        [JsonPropertyName("InternationalDomestic")]
        public string InternationalDomestic { get; set; }

        [JsonPropertyName("Sector")]
        public string Sector { get; set; }

        [JsonPropertyName("Industry")]
        public string Industry { get; set; }

        [JsonPropertyName("GicSector")]
        public string GicSector { get; set; }

        [JsonPropertyName("GicGroup")]
        public string GicGroup { get; set; }

        [JsonPropertyName("GicIndustry")]
        public string GicIndustry { get; set; }

        [JsonPropertyName("GicSubIndustry")]
        public string GicSubIndustry { get; set; }
        
        [JsonPropertyName("Address")]
        public string Address { get; set; }

        [JsonPropertyName("Phone")]
        public string Phone { get; set; }

        [JsonPropertyName("WebURL")]
        public string WebUrl { get; set; }

        [JsonPropertyName("LogoURL")]
        public string LogoUrl { get; set; }

        [JsonPropertyName("FullTimeEmployees")]
        public long FullTimeEmployees { get; set; }

        [JsonPropertyName("UpdatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
