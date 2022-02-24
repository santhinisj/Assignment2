using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class SecretInstrucionsController : ApiController
    {

        [Route("api/J3/Secret/{secretcode}")]

        //J3 -2021 - Secret Instruction Problem
        // this method accepts a number which contains 5 digits which represents a direction to
        // turn and number of steps to tke.
        // First two digits represent the direction to turn
        //If their sum is odd, then the direction to turn is left.
        //If their sum is even, then the direction to turn is right.
        //api/J3/Secret/57234 returns right 234
        //api/J3/Secret/00907 returns right 907
        //api/J3/Secret/34100 returns left 100
        public string Get(string secretcode)
        {
            int firstDigit = secretcode[0];
            int secondDigit = secretcode[1];
            if ((firstDigit + secondDigit) % 2 == 0) {
                return "right " + secretcode[2]+secretcode[3]+secretcode[4];
            }
            else
            {
                return "left " + secretcode[2] + secretcode[3] + secretcode[4];
            }
           
        }

       
    }
}