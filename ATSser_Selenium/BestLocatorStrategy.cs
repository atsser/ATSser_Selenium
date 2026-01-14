using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class BestLocatorStrategy
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                // Preferred locator example (relative XPath)
                IWebElement emailField =
                    driver.FindElement(By.XPath("//input[@name='email']"));
                emailField.SendKeys("test@example.com");

                Console.WriteLine("Element located using best locator strategy.");

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
