using System.Data;
using System.Net.WebSockets;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium_Random_Car.Helpers;

namespace Selenium_Random_Car
{
    public class bot
    {
        public static void Main(string[] args)
        {
            RandomNum RandomNum = new RandomNum();
            NumberOfOptionsInDrpDown OptDrp = new NumberOfOptionsInDrpDown();



            Console.WriteLine("Welcome to Binura's random car picker!");
            Console.WriteLine();
            Console.WriteLine("Perfect if you don't know which model to choose! ;)");
            Console.WriteLine();
            string metroUserName = "bwanigabaduge";
            string metroPassword = "Metro@123";
            Console.WriteLine("Do you want a new/used car?");
            string usedOrNewCar = Console.ReadLine();
            string UsedOrNewCar = usedOrNewCar.ToLower().Trim();
            Console.WriteLine();
            Console.WriteLine("What brand is your required car?");
            string brandOfCar = Console.ReadLine();
            string BrandOfCar = brandOfCar.ToUpper().Trim();
            Console.WriteLine();
            Console.WriteLine("Okay!, time to search!");
            Console.WriteLine();

            if (UsedOrNewCar == "new")
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate().GoToUrl("https://systest-metro-broker-portal.systest.metrofin.com.au/");

                IWebElement txtUserName = driver.FindElement(By.Id("username"));
                txtUserName.SendKeys(metroUserName);

                IWebElement txtPassword = driver.FindElement(By.Id("passwd"));
                txtPassword.SendKeys(metroPassword + Keys.Enter);

                IWebElement btnVehicleSearch = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/ul/li[11]/a"));
                btnVehicleSearch.Click();

                IWebElement drpAssetType = driver.FindElement(By.Id("ddlAssetType"));
                var drpAssetTypeSelectObj = new SelectElement(drpAssetType);
                drpAssetTypeSelectObj.SelectByIndex(1);

                if (UsedOrNewCar == "new")
                {
                    IWebElement btnnewCar = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/ng-view/div/div[2]/main/div/div[1]/div[2]/div[1]/div[1]/form/div/jato-search/ng-form/div[4]/div/div/label[1]/input"));
                    btnnewCar.Click();
                }
                else
                {
                    IWebElement btnoldCar = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/ng-view/div/div[2]/main/div/div[1]/div[2]/div[1]/div[1]/form/div/jato-search/ng-form/div[4]/div/div/label[2]/input"));
                    btnoldCar.Click();
                }

                IWebElement drpMake = driver.FindElement(By.Id("ddlJatoMakes"));
                var drpMakeSelectObj = new SelectElement(drpMake);
                drpMakeSelectObj.SelectByText(BrandOfCar);

                IWebElement drpModel = driver.FindElement(By.Id("ddlJatoModels"));
                int numofOptions = NumberOfOptionsInDrpDown.GetDropDownElementCount(drpModel);
                int randomOption = RandomNum.GetRandomNumber(numofOptions);
                var drpModelSelectObj = new SelectElement(drpModel);
                drpModelSelectObj.SelectByIndex(randomOption);

            }
            else if (UsedOrNewCar == "used")
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate().GoToUrl("https://systest-metro-broker-portal.systest.metrofin.com.au/");

                IWebElement txtUserName = driver.FindElement(By.Id("username"));
                txtUserName.SendKeys(metroUserName);

                IWebElement txtPassword = driver.FindElement(By.Id("passwd"));
                txtPassword.SendKeys(metroPassword + Keys.Enter);

                IWebElement btnVehicleSearch = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/ul/li[11]/a"));
                btnVehicleSearch.Click();

                IWebElement drpAssetType = driver.FindElement(By.Id("ddlAssetType"));
                var selectObj = new SelectElement(drpAssetType);
                selectObj.SelectByIndex(1);

                if (UsedOrNewCar == "new")
                {
                    IWebElement btnnewCar = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/ng-view/div/div[2]/main/div/div[1]/div[2]/div[1]/div[1]/form/div/jato-search/ng-form/div[4]/div/div/label[1]/input"));
                    btnnewCar.Click();
                }
                else
                {
                    IWebElement btnoldCar = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/ng-view/div/div[2]/main/div/div[1]/div[2]/div[1]/div[1]/form/div/jato-search/ng-form/div[4]/div/div/label[2]/input"));
                    btnoldCar.Click();
                }

                IWebElement drpMake = driver.FindElement(By.Id("ddlJatoMakes"));
                var drpMakeSelectObj = new SelectElement(drpMake);
                drpMakeSelectObj.SelectByText(BrandOfCar);

                IWebElement drpModel = driver.FindElement(By.Id("ddlJatoModels"));
                int numofOptions = NumberOfOptionsInDrpDown.GetDropDownElementCount(drpModel);
                int randomOption = RandomNum.GetRandomNumber(numofOptions);
                var drpModelSelectObj = new SelectElement(drpModel);
                drpModelSelectObj.SelectByIndex(randomOption);


            }
            else
            {
                Console.WriteLine("Please rerun the code and put in a proper input! :(");
                Console.ReadKey();
            }
            
        }

    }
}