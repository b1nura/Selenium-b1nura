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
        public static int numInDrpDown(IWebElement element)
        {
            SelectElement select = new SelectElement(element);
            var elementList = select.Options;
            IList<string> optionStrings = new List<string>();
            for (int i = 0; i < elementList.Count; i++)
            {
                optionStrings.Add(elementList[i].Text);
            }
            return optionStrings.Count;
        }
    }
}
