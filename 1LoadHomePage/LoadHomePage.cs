using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilipTest1
{
    class LoadHomePage
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://digitall.com/";
            try
            {
                IWebElement element = driver.FindElement(By.XPath("//*[@id=\"digitall__logo\"]"));
                Console.WriteLine("The logo of the page is found and is: " + element);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine($"Assertion failed with the following message:\n" + ex);
            }

            driver.Quit();
        }
    }
}