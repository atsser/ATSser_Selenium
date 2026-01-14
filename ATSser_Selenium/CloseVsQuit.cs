using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATSser_Selenium
{
    class CloseVsQuit
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");
                Thread.Sleep(5000);
                // Open a new tab for demonstration
                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("window.open('https://cogmento.com/','_blank');");

                Console.WriteLine("Two browser windows opened.");
                Thread.Sleep(5000);
                // Close only current window
                driver.Close();
                Console.WriteLine("Closed current window using Close().");

                Console.WriteLine("Press ENTER to Quit all windows...");
                Console.ReadLine();
            }
            finally
            {
                // Quit closes all windows and ends session
                driver.Quit();
                Console.WriteLine("All browser windows closed using Quit().");
            }
        }
    }
}
