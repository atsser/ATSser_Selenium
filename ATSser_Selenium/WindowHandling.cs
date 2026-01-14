using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;

namespace ATSser_Selenium
{
    class WindowHandling
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                // Store parent window
                string parentWindow = driver.CurrentWindowHandle;

                // Open a new tab (for demo purpose)
                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("window.open('https://example.com','_blank');");

                // Switch to child window
                foreach (string window in driver.WindowHandles)
                {
                    if (window != parentWindow)
                    {
                        driver.SwitchTo().Window(window);
                        break;
                    }
                }

                Console.WriteLine("Child Window Title: " + driver.Title);

                // Switch back to parent window
                driver.SwitchTo().Window(parentWindow);
                Console.WriteLine("Back to Parent Window Title: " + driver.Title);

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
