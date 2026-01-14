using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class SvgLocators
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");
                Thread.Sleep(5000);
                // Example pattern: locate an SVG icon using name()  //*[name()='svg'] //*[name()='path']
                // Update the XPath based on the SVG icon you target in Cogmento.
                IWebElement svgIcon = driver.FindElement(By.XPath("//*[name()='svg']"));

                // Often clicking SVG directly is not reliable, but shown for learning:
                svgIcon.Click();

                Console.WriteLine("SVG located using name()='svg' pattern.");

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
