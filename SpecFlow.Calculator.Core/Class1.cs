﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Calculator.Core
{
    public class CalculatorManager
    {
        public int Number1 { get; set; }

        public int Number2 { get; set; }

        public int Add()
        {
            return Number1 + Number2;
        }
    }
}
