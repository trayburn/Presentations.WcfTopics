using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using StockFinder;

namespace WcfTopics_Basic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(StockLookup)))
            {
                host.Open();
                Console.WriteLine("Host is now running...");
                Console.WriteLine(">>> Press Enter To Stop <<<");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
