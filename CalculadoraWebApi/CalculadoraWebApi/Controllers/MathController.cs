using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculadoraWebApi.Controllers
{
    public class MathController : ApiController
    {
        [HttpGet]
        public int sum(int field1, int field2)
        {
            return field1 + field2;
        }

        [HttpGet]
        public int substraction(int field1, int field2)
        {
            return field1 - field2;
        }

        [HttpGet]
        public int multiply(int field1, int field2)
        {
            return field1 * field2;
        }

        [HttpGet]
        public int division(int field1, int field2)
        {
            return field1 / field2;
        }

        [HttpGet]
        public string Get()
        {
            return "result";
        }
    }
}
