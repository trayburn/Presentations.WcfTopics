using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace StockFinder
{
    // DataContract
    [DataContract]
    public class StockInfo
    {
        [DataMember]
        public string Symbol { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
