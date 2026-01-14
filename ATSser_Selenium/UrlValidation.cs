using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class UrlValidation
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                // Read current URL
                string currentUrl = driver.Url;
                Console.WriteLine("Current URL: " + currentUrl);

                // Simple validation
                if (currentUrl.Contains("cogmento"))
                {
                    Console.WriteLine("URL validation passed.");
                }
                else
                {
                    Console.WriteLine("URL validation failed.");
                }

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
