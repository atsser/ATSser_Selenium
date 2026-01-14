using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class DriverReuse
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver(); // Created once (reused)

            try
            {
                driver.Manage().Window.Maximize();

                // Step 1 - First navigation
                driver.Navigate().GoToUrl("https://ui.cogmento.com");
                Console.WriteLine("Step 1 Title: " + driver.Title);

                // Step 2 - Reuse same driver for another action
                driver.Navigate().GoToUrl("https://cogmento.com");
                Console.WriteLine("Step 2 Title: " + driver.Title);

                Console.WriteLine("Press ENTER to close...");
                Console.ReadLine();
            }
            finally
            {
                driver.Quit(); // Clean up after reuse
            }
        }
    }
}
