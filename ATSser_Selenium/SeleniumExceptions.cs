using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace ATSser_Selenium
{
    class SeleniumExceptions
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://ui.cogmento.com");

                // Example: NoSuchElementException
                driver.FindElement(By.Id("nonExistingElement"));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Handled NoSuchElementException");
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Handled TimeoutException");
            }
            catch (StaleElementReferenceException)
            {
                Console.WriteLine("Handled StaleElementReferenceException");
            }
            catch (ElementNotInteractableException)
            {
                Console.WriteLine("Handled ElementNotInteractableException");
            }
            catch (WebDriverException)
            {
                Console.WriteLine("Handled WebDriverException");
            }
            finally
            {
                Console.WriteLine("Press ENTER to close...");
                Console.ReadLine();
                driver.Quit();
            }
        }
    }
}
