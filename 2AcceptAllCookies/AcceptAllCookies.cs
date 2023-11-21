using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace FilipTest1
{
    class AcceptAllCookies
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://digitall.com/";
            try
            {
                IWebElement element = driver.FindElement(By.XPath("//*[@id=\"cookiescript_accept\"]"));
                Console.WriteLine("The 'ACCEPT ALL' button of the page is found and is: " + element);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Assertion failed with the following exception:\n" + ex);
            }

            try
            {
                IWebElement element1 = driver.FindElement(By.XPath("//*[@id=\"cookiescript_accept\"]"));
                element1.Click();
                Console.WriteLine("The 'ACCEPT ALL' button of the page is found and has been clicked");
            }
            catch (NoSuchElementException ex1)
            {
                Console.WriteLine("Assertion failed with the following exception1:\n" + ex1);
            }

            driver.Quit();
        }
    }
}