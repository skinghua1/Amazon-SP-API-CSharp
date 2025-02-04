﻿using FikaAmazonAPI.Search;
using System;
using System.Collections.Generic;
using System.Text;
using static FikaAmazonAPI.AmazonSpApiSDK.Models.FbaInventory.Granularity;
using static FikaAmazonAPI.Utils.Constants;

namespace FikaAmazonAPI.Parameter.FbaInventory
{
    public class ParameterGetInventorySummaries : ParameterBased
    {
        public bool? details { get; set; }
        public string granularityId { get; set; }
        public DateTime? startDateTime { get; set; }
        public IList<string> sellerSkus { get; set; }
        public string nextToken { get; set; }
        public IList<string> marketplaceIds { get; set; }
        public GranularityTypeEnum granularityType { get; set; }
    }
}
