﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FikaAmazonAPI.Search
{
    public class ParameterMarketplaceId : ParameterBased
    {
        public ParameterMarketplaceId()
        {
            marketplaceIds = new List<string>();
        }
        public ParameterMarketplaceId(string marketplaceId)
        {
            marketplaceIds = new List<string>();
            marketplaceIds.Add(marketplaceId);
        }
        public IList<string> marketplaceIds { get; set; }
    }
}
