using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium_Random_Car.Helpers
{
    public class RandomNum
    {
        public static int GetRandomNumber(int num)
        {
            Random random = new Random();
            int newRandomNumber = random.Next(1, num);
            return newRandomNumber;

        }

    }


}
