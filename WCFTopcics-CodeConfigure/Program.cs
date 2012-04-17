using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using StockFinder;
using System.ServiceModel.Description;

namespace WCFTopcics_CodeConfigure
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a code-configured host, NOTE that
            // the project has no App.Config
            using (var host = new ServiceHost(
                typeof(StockLookup), 
                new Uri("http://localhost:1701/")))
            {
                var binding = new WSHttpBinding();
                var ep = host.AddServiceEndpoint(
                    typeof(IStockLookup),   // Contract
                    binding,                // Binding
                    "Stock");               // Address

                var smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);

                host.Open();
                Console.WriteLine("Host is now running...");
                Console.WriteLine(">>> Press Enter To Stop <<<");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
