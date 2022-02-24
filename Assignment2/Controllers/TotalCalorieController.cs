using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class TotalCalorieController : ApiController
    {
        //J1 problem
        // GET api/J1/Menu/4/4/4/4 --> returns 0
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        //This method accepts 4 index parameters and return the total calories
        public string Get(int burger, int drink, int side, int dessert)
        {
            int[] burgerCalorieList = { 461, 431, 420, 0 };
            int[] softDrinkCalorieList = { 130, 160, 118, 0 };
            int[] sideCalorieList = { 100, 57, 70, 0 };
            int[] dessertCalorieList = { 167, 266, 75, 0 };
            int totalCalories = burgerCalorieList[burger-1]+ softDrinkCalorieList[drink-1] + sideCalorieList[side-1] + dessertCalorieList[dessert-1];
            return "Your total calorie count is "+ totalCalories;
        }

    }
}