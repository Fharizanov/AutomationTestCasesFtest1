using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace FilipTest1
{
    class AboutUsContactUs
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://digitall.com/";
            try
            {
                IWebElement element = driver.FindElement(By.XPath("//*[@id=\"primary-nav\"]/li[4]/a"));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();
                Console.WriteLine("The 'ABOUT US' button of the page is found and has been hovered");
            }
            catch (NoSuchElementException ex) 
            {
                Console.WriteLine("Assertion failed with the following exception:\n" + ex);
            }

            Thread.Sleep(1000);
            try
            {
                IWebElement element1 = driver.FindElement(By.XPath("//*[@id=\"primary-nav\"]/li[4]/div/div/div/a[6]"));
                element1.Click();
                Console.WriteLine("The 'Contact us' button of the page is found and has been clicked");
            }
            catch (NoSuchElementException ex1)
            {
                Console.WriteLine("Assertion failed with the following exception1:\n" + ex1);
            }

            driver.Quit();
        }
    }
}