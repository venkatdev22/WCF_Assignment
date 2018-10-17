using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace JobServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(JobService.JobService)))
            {
                host.Open();
                Console.WriteLine("Job Service Host started @ " + DateTime.Now.ToString());
                Console.WriteLine("Job Service Host is running... Press <Enter> key to stop ");
                Console.ReadLine();
            }
        }
    }
}
