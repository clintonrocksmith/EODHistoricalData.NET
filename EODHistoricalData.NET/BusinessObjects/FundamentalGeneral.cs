using System.Text.Json;
using System;
using System.Collections.Generic;

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
        
        /// <summary>
        /// Returns true or false if the listing is no longer traded
        /// </summary>
        [JsonProperty("IsDelisted")]
        public bool IsDelisted { get; set; }
        
        /// <summary>
        /// The date that the listing was no longer traded
        /// </summary>
        [JsonProperty("DelistedDate")]
        public DateTimeOffset? DelistedDate { get; set; }
        
        /// <summary>
        /// The Address in a human readable form
        /// </summary>
        [JsonProperty("Address")]
        public string Address { get; set; }

        /// <summary>
        /// The Data for the Address
        /// </summary>
        [JsonProperty("AddressData")]
        public AddressData AddressData { get; set; }

        /// <summary>
        /// The different listings on different exchanges
        /// </summary>
        [JsonProperty("Listings")] 
        public Dictionary<int, Listing> Listings { get; set; }

        /// <summary>
        /// The officers for the listing if known
        /// </summary>
        [JsonProperty("Officers")] 
        public Dictionary<int, Officer> Officers { get; set; }
        
        [JsonProperty("Phone")]
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

    public class AddressData
    {
        /// <summary>
        /// The Number and Name of the street
        /// </summary>
        [JsonProperty("Street")]
        public string Street { get; set; }
        
        /// <summary>
        /// The City of the Address
        /// </summary>
        [JsonProperty("City")]
        public string City { get; set; }
        
        /// <summary>
        /// The Country of the Address
        /// </summary>
        [JsonProperty("Country")]
        public string Country { get; set; }
        
        /// <summary>
        /// The Zip or Postcode of the Address
        /// </summary>
        [JsonProperty("ZIP")]
        public string ZIP { get; set; }
        
    }

    public class Listing
    {
        /// <summary>
        /// The Stock Code
        /// </summary>
        [JsonProperty("Code")]
        public string Code { get; set; }
        
        /// <summary>
        /// The Exchange if known
        /// Can be empty or null
        /// </summary>
        [JsonProperty("Exchange")]
        public string Exchange { get; set; }
        
        /// <summary>
        /// The Alternative Name for the Company 
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }
    }

    public class Officer
    {
        /// <summary>
        /// The Name of the person including their salutation
        /// example: Ms. Charlotte  Emery
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }
        
        /// <summary>
        /// The Title the person held
        /// </summary>
        [JsonProperty("Title")]
        public string Title { get; set; }
        
        /// <summary>
        /// The year that the person was born if known
        /// If Unknown returns "NA" and could be null or empty
        /// </summary>
        [JsonProperty("YearBorn")]
        public string YearBorn { get; set; }
    }
}
