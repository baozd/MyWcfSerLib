using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace MyWcfSerLib.Host
{
    public class Host
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(Service.Service)))
            {
                host.Open();
                Console.WriteLine("WCF is Running.....");
                Console.Read();
            }
        }
    }
}