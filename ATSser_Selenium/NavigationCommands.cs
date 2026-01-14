using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class NavigationCommands
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();

                // Navigate to first page
                driver.Navigate().GoToUrl("https://ui.cogmento.com");
                Console.WriteLine("Opened Cogmento");
                Console.WriteLine("Title: " + driver.Title);

                // Navigate to another page
                driver.Navigate().GoToUrl("https://example.com");
                Console.WriteLine("Navigated to Example.com");

                // Back
                driver.Navigate().Back();
                Console.WriteLine("Navigated Back");

                // Forward
                driver.Navigate().Forward();
                Console.WriteLine("Navigated Forward");

                // Refresh
                driver.Navigate().Refresh();
                Console.WriteLine("Page Refreshed");

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
