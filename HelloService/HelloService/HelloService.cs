using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {
        public string SayHello(string name)
        {
            string greetingMessage = string.Empty;
            if (DateTime.Now.Hour < 12)
                greetingMessage = "Hello "+ name + "! Good Morning.";
            else if (DateTime.Now.Hour < 17)
                greetingMessage = "Hello " + name + "! Good Afternoon.";
            else
                greetingMessage = "Hello " + name + "! Good Evening.";
            return greetingMessage;
        }

        public string TodayProgram(string name)
        {
            string greeting = string.Empty;
            DayOfWeek today = DateTime.Now.DayOfWeek;

            if (today == DayOfWeek.Sunday || today == DayOfWeek.Saturday)
                greeting = "Hello " + name + "! Happy Weekend.";
            else
                greeting = "Hello " + name + "! Enjoy Working day.";
            return greeting;
        }
    }
}
