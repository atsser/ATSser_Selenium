using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class TimeoutsExample
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                // Set timeouts
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                Console.WriteLine("Page loaded using configured timeouts.");
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
