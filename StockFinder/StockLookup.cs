using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace StockFinder
{
    // Contract
    [ServiceContract]
    public interface IStockLookup
    {
        [OperationContract]
    	double GetPrice(string symbol);
        [OperationContract]
        StockInfo GetInfo(string symbol);
    }

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

    // Service Implementation
    public class StockLookup : IStockLookup
    {
        public double GetPrice(string symbol)
        {
            if (symbol.Equals("MSFT", StringComparison.InvariantCultureIgnoreCase))
                return 598.27;
            else return 123.45;
        }

        public StockInfo GetInfo(string symbol)
        {
            if (symbol.Equals("MSFT", StringComparison.InvariantCultureIgnoreCase))
                return new StockInfo
                {
                    Symbol = "MSFT",
                    Price = 598.27,
                    Description = "Creators of the amazing .NET Framework"
                };
            else return new StockInfo
            {
                Symbol = symbol,
                Price = 123.45,
                Description = "Some random stock"
            };
        }
    }
}
