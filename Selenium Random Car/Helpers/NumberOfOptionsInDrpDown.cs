using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Random_Car.Helpers
{
    public class NumberOfOptionsInDrpDown
    {
        public static int GetDropDownElementCount(IWebElement element)
        {
            SelectElement select = new SelectElement(element);
            var elementList = select.Options;

            return elementList.Count;
        }
    }
}
