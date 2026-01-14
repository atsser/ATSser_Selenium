using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace ATSser_Selenium
{
    class PageInfo
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");
                Thread.Sleep(3000);

                Console.WriteLine("Login Page Title: " + driver.Title);
                Console.WriteLine("Login Page URL: " + driver.Url);

                driver.FindElement(By.Name("email")).SendKeys("yella.v.reddy@gmail.com");
                driver.FindElement(By.Name("password")).SendKeys("9876543210");
                driver.FindElement(By.XPath("//div[text()='Login']")).Click();
                Thread.Sleep(5000);

                Console.WriteLine("Dashboard Page Title: " + driver.Title);
                Console.WriteLine("Dashboard Page URL: " + driver.Url);
                Console.WriteLine("Press ENTER to close the browser...");
                Console.Read();
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
