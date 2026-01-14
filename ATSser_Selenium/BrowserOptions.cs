using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class BrowserOptions
    {
        public void Run()
        {
            // Configure browser options
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            options.AddArgument("--disable-notifications");
            options.AddArgument("--start-maximized");

            IWebDriver driver = new ChromeDriver(options);

            try
            {
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                Console.WriteLine("Browser launched with custom options.");
                Console.WriteLine("Title: " + driver.Title);

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
