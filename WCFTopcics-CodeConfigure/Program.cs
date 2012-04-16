using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using StockFinder;

namespace WCFTopcics_CodeConfigure
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a code-configured host, NOTE that
            // the project has no App.Config
            using (var host = new ServiceHost(typeof(StockLookup)))
            {
                var binding = new WSHttpBinding();
                host.AddServiceEndpoint(
                    typeof(IStockLookup),               // Contract
                    binding,                            // Binding
                    "http://localhost:1701/Stock");     // Address

                host.Open();
                Console.WriteLine("Host is now running...");
                Console.WriteLine(">>> Press Enter To Stop <<<");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
