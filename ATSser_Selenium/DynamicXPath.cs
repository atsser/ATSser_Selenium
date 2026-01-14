using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class DynamicXPath
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                // Dynamic XPath using contains()
                driver.FindElement(By.XPath("//input[contains(@name,'email')]"))
                      .SendKeys("test@example.com");

                driver.FindElement(By.XPath("//input[contains(@name,'password')]"))
                      .SendKeys("password");

                Console.WriteLine("Dynamic XPath used successfully.");

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
