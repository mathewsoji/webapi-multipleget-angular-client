using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WepAPI_Demo.Controllers
{
    public class MathController : ApiController
    {

        [HttpGet]
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        [HttpGet]
        public int Substract(int value1, int value2)
        {
            return value1 - value2;
        }

        [HttpGet]
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        [HttpGet]
        public int Divide(int value1, int value2)
        {
            if ( (value1 == 0) || (value2==0))
            {
                HttpResponseMessage ex = new HttpResponseMessage();
                ex.StatusCode = HttpStatusCode.BadRequest;
                ex.ReasonPhrase = "Value can not be zero!";
                throw new HttpResponseException(ex);
            }
            else
            {
                return value1 / value2;
            }
          
        }


        [HttpGet]
        public string Get()
        {
            return "default";
           
        }



    }
}
