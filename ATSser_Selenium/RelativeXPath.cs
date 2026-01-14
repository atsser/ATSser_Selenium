using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class RelativeXPath
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                // Locate elements using Relative XPath
                driver.FindElement(By.XPath("//input[@name='email']"))
                      .SendKeys("yella.v.reddy@gmail.com");

                driver.FindElement(By.XPath("//input[@name='password']"))
                      .SendKeys("EnterPassword");

                Console.WriteLine("Relative XPath used successfully.");

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
