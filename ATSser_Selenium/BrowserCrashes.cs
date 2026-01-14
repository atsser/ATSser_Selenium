using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class BrowserCrashes
    {
        public void Run()
        {
            IWebDriver driver = null;

            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                Console.WriteLine("Browser session started successfully.");
                Console.WriteLine("Title: " + driver.Title);

                // Demo note: we are not crashing the browser intentionally.
                // This code shows how to handle crash/disconnect if it happens.
                Console.WriteLine("If browser crashes/disconnects, WebDriverException is handled.");
            }
            catch (WebDriverException ex)
            {
                Console.WriteLine("Browser crash / disconnect detected.");
                Console.WriteLine("WebDriverException: " + ex.Message);
            }
            finally
            {
                try
                {
                    driver?.Quit();
                }
                catch
                {
                    // Ignore cleanup exceptions if browser already crashed
                }

                Console.WriteLine("Press ENTER to finish...");
                Console.ReadLine();
            }
        }
    }
}
