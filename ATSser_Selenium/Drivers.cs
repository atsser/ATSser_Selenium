using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class Drivers
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                Console.WriteLine("Driver launched browser successfully.");
                Console.WriteLine("Title: " + driver.Title);
                Console.WriteLine("URL: " + driver.Url);

                Console.WriteLine("Press ENTER to close the browser...");
                Console.ReadLine();
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
