using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class SeleniumLimitations
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                Console.WriteLine("Selenium can automate web UI elements.");
                Console.WriteLine("Selenium cannot handle CAPTCHA, OTP, or desktop apps.");
                Console.WriteLine("Selenium focuses on browser-based automation only.");

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
