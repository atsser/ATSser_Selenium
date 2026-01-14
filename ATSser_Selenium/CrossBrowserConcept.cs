using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;

namespace ATSser_Selenium
{
    class CrossBrowserConcept
    {
        public void Run()
        {
            IWebDriver driver = null;

            // Change browser name to "edge" or "chrome"
            string browser = "edge";

            try
            {
                if (browser.Equals("chrome"))
                {
                    driver = new ChromeDriver();
                }
                else if (browser.Equals("edge"))
                {
                    driver = new EdgeDriver();
                }

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                Console.WriteLine("Browser launched: " + browser);
                Console.WriteLine("Title: " + driver.Title);
                Console.WriteLine("Press ENTER to close...");
                Console.ReadLine();
            }
            finally
            {
                driver?.Quit();
            }
        }
    }
}
