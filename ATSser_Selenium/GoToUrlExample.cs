using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class GoToUrlExample
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();

                // Navigate to application
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                Console.WriteLine("Navigation successful using GoToUrl");
                Console.WriteLine("Title: " + driver.Title);
                Console.WriteLine("Current URL: " + driver.Url);

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
