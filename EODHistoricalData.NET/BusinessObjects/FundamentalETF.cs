﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using EODHistoricalData.NET;
//
//    var fundamentalEtFs = FundamentalEtFs.FromJson(jsonString);

namespace EODHistoricalData.NET
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using EODHistoricalData.NET.BusinessObjects;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class FundamentalETF
    {
        [JsonProperty("General")]
        public FundamentalGeneral General { get; set; }

        [JsonProperty("Technicals")]
        public FundamentalTechnicals Technicals { get; set; }

        [JsonProperty("ETF_Data")]
        public EtfData EtfData { get; set; }
    }

    public partial class EtfData
    {
        [JsonProperty("ISIN")]
        public string Isin { get; set; }

        [JsonProperty("Company_Name")]
        public string CompanyName { get; set; }

        [JsonProperty("Company_URL")]
        public Uri CompanyUrl { get; set; }

        [JsonProperty("ETF_URL")]
        public Uri EtfUrl { get; set; }

        [JsonProperty("Yield")]
        public decimal? Yield { get; set; }

        [JsonProperty("Dividend_Paying_Frequency")]
        public string DividendPayingFrequency { get; set; }

        [JsonProperty("Inception_Date")]
        public DateTimeOffset InceptionDate { get; set; }

        [JsonProperty("Max_Annual_Mgmt_Charge")]
        public decimal? MaxAnnualMgmtCharge { get; set; }

        [JsonProperty("Ongoing_Charge")]
        public decimal? OngoingCharge { get; set; }

        [JsonProperty("Date_Ongoing_Charge")]
        public string DateOngoingCharge { get; set; }

        [JsonProperty("NetExpenseRatio")]
        public decimal? NetExpenseRatio { get; set; }

        [JsonProperty("AnnualHoldingsTurnover")]
        public decimal? AnnualHoldingsTurnover { get; set; }

        [JsonProperty("TotalAssets")]
        public decimal? TotalAssets { get; set; }

        [JsonProperty("Average_Mkt_Cap_Mil")]
        public string AverageMktCapMil { get; set; }

        [JsonProperty("Market_Capitalisation")]
        public MarketCapitalisation MarketCapitalisation { get; set; }

        [JsonProperty("Asset_Allocation")]
        public AssetAllocation AssetAllocation { get; set; }

        [JsonProperty("World_Regions")]
        public Dictionary<string, AllocWeight> WorldRegions { get; set; }

        [JsonProperty("Sector_Weights")]
        public Dictionary<string, AllocWeight> SectorWeights { get; set; }

        [JsonProperty("Top_10_Holdings")]
        public Dictionary<string, Holding> Top10_Holdings { get; set; }

        [JsonProperty("Holdings")]
        public Dictionary<string, Holding> Holdings { get; set; }

        [JsonProperty("Valuations_Growth")]
        public ValuationsGrowth ValuationsGrowth { get; set; }

        [JsonProperty("MorningStar")]
        public MorningStar MorningStar { get; set; }

        [JsonProperty("Performance")]
        public Performance Performance { get; set; }
    }

    public partial class AssetAllocation
    {
        [JsonProperty("Stock")]
        public Allocation Stock { get; set; }

        [JsonProperty("Bond")]
        public Allocation Bond { get; set; }

        [JsonProperty("Property")]
        public Allocation Property { get; set; }

        [JsonProperty("Cash")]
        public Allocation Cash { get; set; }

        [JsonProperty("Other")]
        public Allocation Other { get; set; }
    }

    public partial class Allocation
    {
        [JsonProperty("Long_ % ")]
        public decimal? Long { get; set; }

        [JsonProperty("Short_ % ")]
        public decimal? Short { get; set; }

        [JsonProperty("Net_Assets_ % ")]
        public decimal? NetAssets { get; set; }
    }

    public partial class Holding
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Sector")]
        public string Sector { get; set; }

        [JsonProperty("Industry")]
        public string Industry { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("Assets_ % ")]
        public decimal? Assets { get; set; }
    }

    public partial class MarketCapitalisation
    {
        [JsonProperty("Mega")]
        public decimal? Mega { get; set; }

        [JsonProperty("Big")]
        public decimal? Big { get; set; }

        [JsonProperty("Medium")]
        public decimal? Medium { get; set; }

        [JsonProperty("Small")]
        public decimal? Small { get; set; }

        [JsonProperty("Micro")]
        public decimal? Micro { get; set; }
    }

    public partial class MorningStar
    {
        [JsonProperty("Ratio")]
        public long Ratio { get; set; }

        [JsonProperty("Category_Benchmark")]
        public string CategoryBenchmark { get; set; }

        [JsonProperty("Sustainability_Ratio")]
        public long SustainabilityRatio { get; set; }
    }

    public partial class Performance
    {
        [JsonProperty("3y_Volatility")]
        public decimal? The3YVolatility { get; set; }

        [JsonProperty("3y_ExpReturn")]
        public decimal? The3YExpReturn { get; set; }

        [JsonProperty("3y_SharpRatio")]
        public decimal? The3YSharpRatio { get; set; }

        [JsonProperty("Returns_YTD")]
        public decimal? ReturnsYtd { get; set; }

        [JsonProperty("Returns_3Y")]
        public decimal? Returns3Y { get; set; }

        [JsonProperty("Returns_5Y")]
        public decimal? Returns5Y { get; set; }

        [JsonProperty("Returns_10Y")]
        public decimal? Returns10Y { get; set; }
    }

    public partial class AllocWeight
    {
        [JsonProperty("Equity_ % ")]
        public decimal? Equity { get; set; }

        [JsonProperty("Relative_to_Category")]
        public decimal? RelativeToCategory { get; set; }
    }

    public partial class ValuationsGrowth
    {
        [JsonProperty("Valuations_Rates_Portfolio")]
        public ValuationsRates ValuationsRatesPortfolio { get; set; }

        [JsonProperty("Valuations_Rates_To_Category")]
        public ValuationsRates ValuationsRatesToCategory { get; set; }

        [JsonProperty("Growth_Rates_Portfolio")]
        public GrowthRates GrowthRatesPortfolio { get; set; }

        [JsonProperty("Growth_Rates_To_Category")]
        public GrowthRates GrowthRatesToCategory { get; set; }
    }

    public partial class GrowthRates
    {
        [JsonProperty("Long-Term Projected Earnings Growth")]
        public decimal? LongTermProjectedEarningsGrowth { get; set; }

        [JsonProperty("Historical Earnings Growth")]
        public decimal? HistoricalEarningsGrowth { get; set; }

        [JsonProperty("Sales Growth")]
        public decimal? SalesGrowth { get; set; }

        [JsonProperty("Cash-Flow Growth")]
        public decimal? CashFlowGrowth { get; set; }

        [JsonProperty("Book-Value Growth")]
        public decimal? BookValueGrowth { get; set; }
    }

    public partial class ValuationsRates
    {
        [JsonProperty("Price/Prospective Earnings")]
        public decimal? PriceProspectiveEarnings { get; set; }

        [JsonProperty("Price/Book")]
        public decimal? PriceBook { get; set; }

        [JsonProperty("Price/Sales")]
        public decimal? PriceSales { get; set; }

        [JsonProperty("Price/Cash Flow")]
        public decimal? PriceCashFlow { get; set; }

        [JsonProperty("Dividend-Yield Factor")]
        public decimal? DividendYieldFactor { get; set; }
    }
    
    public partial class FundamentalETF
    {
        public static FundamentalETF FromJson(string json) => JsonConvert.DeserializeObject<FundamentalETF>(json, EODHistoricalData.NET.ConverterFundamentalETF.Settings);
    }

    public static class SerializeFundamentalETF
    {
        public static string ToJson(this FundamentalETF self) => JsonConvert.SerializeObject(self, EODHistoricalData.NET.ConverterFundamentalETF.Settings);
    }

    internal static class ConverterFundamentalETF
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
