using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Castle.Windsor;
using StockFinder;
using Castle.MicroKernel.Registration;

namespace WcfTopics_IoC
{
    class Program
    {
        public static IWindsorContainer Container = new WindsorContainer();

        static void Main(string[] args)
        {
            // Configure IoC
            Container.Register(
                Component.For<IStockLookup>()
                .ImplementedBy<StockLookup>());

            // Configure Host
            using (var host = new ServiceHost(
                typeof(StockLookup),
                new Uri("http://localhost:1701/")))
            {
                var binding = new WSHttpBinding();
                var ep = host.AddServiceEndpoint(
                    typeof(IStockLookup),   // Contract
                    binding,                // Binding
                    "Stock");               // Address

                var ioc = new WindsorServiceBehavior();
                host.Description.Behaviors.Add(ioc);

                host.Open();
                Console.WriteLine("Host is now running...");
                Console.WriteLine(">>> Press Enter To Stop <<<");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}