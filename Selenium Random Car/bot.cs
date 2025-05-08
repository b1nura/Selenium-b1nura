using System.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Random_Car
{
    public class bot
    {
        public static void Main(string[] args)
        {
            string metroUserName = "bwanigabaduge";
            string metroPassword = "dummy";
            Console.WriteLine("Do you want a new/used car?");
            string oldOrNewCar = Console.ReadLine();
            string OldOrNewCar = oldOrNewCar.ToLower().Trim();

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("dummy");

            IWebElement txtUserName = driver.FindElement(By.Id("username"));
            txtUserName.SendKeys(metroUserName);

            IWebElement txtPassword = driver.FindElement(By.Id("passwd"));
            txtPassword.SendKeys(metroPassword + Keys.Enter);

            IWebElement btnVehicleSearch = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/ul/li[11]/a"));
            btnVehicleSearch.Click();

            IWebElement drpAssetType = driver.FindElement(By.Id("ddlAssetType"));
            var selectObj = new SelectElement(drpAssetType);
            selectObj.SelectByIndex(1);

            if (OldOrNewCar == "new")
            {
                IWebElement btnnewCar = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/ng-view/div/div[2]/main/div/div[1]/div[2]/div[1]/div[1]/form/div/jato-search/ng-form/div[4]/div/div/label[1]/input"));
                btnnewCar.Click();
            }
            else
            {
                IWebElement btnoldCar = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/ng-view/div/div[2]/main/div/div[1]/div[2]/div[1]/div[1]/form/div/jato-search/ng-form/div[4]/div/div/label[2]/input"));
                btnoldCar.Click();
            }

        }

    }
}