﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in both code and config file together.
    public class CalculatorService : ICalculatorService
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Sub(double number1, double number2)
        {
            return number1 - number2;
        }
    }
}
