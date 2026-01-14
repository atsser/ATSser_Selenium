using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class CookiesExample
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                // READ cookies
                var cookies = driver.Manage().Cookies.AllCookies;
                Console.WriteLine("Initial cookies count: " + cookies.Count);

                // ADD cookie
                Cookie testCookie = new Cookie("ATSserCookie", "InitialValue");
                driver.Manage().Cookies.AddCookie(testCookie);
                Console.WriteLine("Cookie added.");

                // UPDATE cookie (delete + add)
                driver.Manage().Cookies.DeleteCookieNamed("ATSserCookie");
                Cookie updatedCookie = new Cookie("ATSserCookie", "UpdatedValue");
                driver.Manage().Cookies.AddCookie(updatedCookie);
                Console.WriteLine("Cookie updated.");

                // READ updated cookie
                Cookie readCookie = driver.Manage().Cookies.GetCookieNamed("ATSserCookie");
                Console.WriteLine("Updated Cookie Value: " + readCookie.Value);

                // DELETE all cookies
                driver.Manage().Cookies.DeleteAllCookies();
                Console.WriteLine("All cookies deleted.");

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
