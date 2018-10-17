using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloService.HelloService)))
            {
                host.Open();
                Console.WriteLine("Host started @ "+ DateTime.Now.ToString());
                Console.WriteLine("Host is running... Press <Enter> key to stop ");
                Console.ReadLine();
            }
        }
    }
}
