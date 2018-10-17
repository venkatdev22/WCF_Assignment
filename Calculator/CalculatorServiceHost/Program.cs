using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CalculatorServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService.CalculatorService)))
            {
                host.Open();
                Console.WriteLine("Calculator Service Host started @ " + DateTime.Now.ToString());
                Console.WriteLine("Calculator Service Host is running... Press <Enter> key to stop ");
                Console.ReadLine();
            }
        }
    }
}
