using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class ConsoleAppFlow
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                // 1) Open application
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                // 2) Validate using console output
                Console.WriteLine("Page Title: " + driver.Title);
                Console.WriteLine("Current URL: " + driver.Url);

                // 3) Keep console open so viewers can see output
                Console.WriteLine("Press ENTER to close the browser...");
                Console.ReadLine();
            }
            finally
            {
                // 4) End session
                driver.Quit();
            }
        }
    }
}
