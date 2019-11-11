using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace _2019Oct
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initiating the driver
            IWebDriver driver = new ChromeDriver();

            //open the google page
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            driver.FindElement(By.Id("UserName")).SendKeys("hari");

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            IWebElement loginBtn = driver.FindElement(By.XPath("//input[@type='submit']"));
            loginBtn.Click();

            //Adminstration link
            var admLnk = driver.FindElement(By.XPath("//a[contains(.,'Administration')]"));
            //var a = 0;
            admLnk.Click();

            //Time n materials
            driver.FindElement(By.XPath("//a[contains(.,'Time & Materials')]")).Click();

            // Click on create new
            driver.FindElement(By.XPath("//a[contains(.,'Create New')]")).Click();

            driver.FindElement(By.Id("Code")).SendKeys("2019Oct");

            driver.FindElement(By.Id("Description")).SendKeys("awesome");

            // assignment to find the price per unit

            driver.FindElement(By.Id("SaveButton")).Click();




            

            Console.ReadKey();

            //close driver
            driver.Quit();
        }
    }
}
