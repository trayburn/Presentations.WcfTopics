using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new MyService.StockLookupClient("WSHttpBinding_IStockLookup");

            Console.WriteLine(proxy.GetPrice("MSFT"));

            if(proxy.GetPrice("MSFT") > proxy.GetPrice("APPL"))
                Console.WriteLine("Buy Microsoft");

            Console.ReadLine();
        }
    }
}
