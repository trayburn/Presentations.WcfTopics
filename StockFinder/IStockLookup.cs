using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace StockFinder
{
    // Contract
    [ServiceContract]
    public interface IStockLookup
    {
        //[WebInvoke(
        //    Method="POST", 
        //    RequestFormat=WebMessageFormat.Json,
        //    ResponseFormat=WebMessageFormat.Json)]
        [OperationContract]
        double GetPrice(string symbol);
        [OperationContract]
        StockInfo GetInfo(string symbol);
    }
}
