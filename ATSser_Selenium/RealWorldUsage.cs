using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class RealWorldUsage
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                Console.WriteLine("Real-world Selenium usage demo");
                Console.WriteLine("Title: " + driver.Title);
                Console.WriteLine("URL: " + driver.Url);

                Console.WriteLine("This simulates a real regression test step.");
                Console.WriteLine("Press ENTER to close...");
                Console.ReadLine();
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
