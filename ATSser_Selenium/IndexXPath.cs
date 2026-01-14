using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class IndexXPath
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");
                //Example:
                //(//input)[1] selects the first matching element
                //(//input)[2] selects the second matching element

                // Using Index XPath (index starts from 1)
                driver.FindElement(By.XPath("(//input)[1]"))
                      .SendKeys("First input field");

                driver.FindElement(By.XPath("(//input)[2]"))
                      .SendKeys("Second input field");

                Console.WriteLine("Index XPath used successfully.");

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
