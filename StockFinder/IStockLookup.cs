using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace StockFinder
{
    // Contract
    [ServiceContract]
    public interface IStockLookup
    {
        [WebGet(ResponseFormat=WebMessageFormat.Json,
            UriTemplate="/GetPrice/{symbol}")]
        [OperationContract]
        double GetPrice(string symbol);
        [OperationContract]
        StockInfo GetInfo(string symbol);
    }
}
