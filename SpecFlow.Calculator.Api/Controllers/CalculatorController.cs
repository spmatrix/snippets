using SpecFlow.Calculator.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SpecFlow.Calculator.Api.Controllers
{
    public class CalculatorController : ApiController
    {
        public string Get()
        {
            return "Hello World!!";
        }

        public int Post([FromBody]CalcModel calcModel)
        {
            return calcModel.Number1 + calcModel.Number2;
        }
    }
}
