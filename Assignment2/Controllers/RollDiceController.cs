using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class RollDiceController : ApiController
    {

        // GET api/J2/DiceGame/6/8 returns "There are 5 ways to get the sum 10"

        [Route("api/J2/DiceGame/{m}/{n}")]
        //method determines how many ways two dice can be rolled to get the value of 10
        public string Get(int m, int n)
        {
            int noOfWaysToGet10 = 0;
            for(int i = 1; i <= m; i++)
            {
                for (int j = 1; j <=n; j++)
                {
                    if(i+j == 10)
                    {
                        noOfWaysToGet10++;

                    }
                }
            }
            if(noOfWaysToGet10 == 1)
            {
                return "There is " + noOfWaysToGet10 + " ways to get the sum 10.";
            }
            else
            {
                return "There are " + noOfWaysToGet10 + " ways to get the sum 10.";
            }
           
        }
    }
}