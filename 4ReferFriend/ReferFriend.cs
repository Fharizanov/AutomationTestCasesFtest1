using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.DOM;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilipTest1
{
    class ReferFriend
    {
        static void ScrollDown(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 500);");
        }
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://digitall.com/";

            //Accepting all cookies
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"cookiescript_accept\"]"));
            Assert.IsTrue(element.Displayed, "Element is not visible");
            element.Click();
            Console.WriteLine("The 'ACCEPT ALL' button of the page is found and has been clicked");

            IWebElement element1 = driver.FindElement(By.XPath("//*[@id=\"primary-nav\"]/li[5]/a"));
            //Checking if the text in the element is as expected: 'CAREERS'
            Assert.AreEqual("CAREERS", element1.Text, "The text of the element is not 'CAREERS'");
            Actions action = new Actions(driver);
            action.MoveToElement(element1).Perform();
            Console.WriteLine("The 'CAREERS' button of the page is found and has been hovered");

            //Added one second waiting as the time is needed in order for the 'Refer a Friend' button to show
            Thread.Sleep(1000);

            //Handling the exception in case the 'Referer a Friend' button is missing
            try
            {
                IWebElement element2 = driver.FindElement(By.XPath("//*[@id=\"primary-nav\"]/li[5]/div/div/div/a[2]"));
                element2.Click();
                Console.WriteLine("The 'Refer a Friend' button of the page is found and has been clicked");
            }
            catch (NoSuchElementException ex) 
            {
                Console.WriteLine("Assertion failed with the following exception:\n" + ex);
            }

            //Filling in the word 'Senior' in the 'Keyword search' field
            IWebElement element3 = driver.FindElement(By.XPath("//*[@id=\"keyword\"]"));
            element3.SendKeys("Senior");
            Console.WriteLine("The 'Keyword search' field of the page is found and the word 'Senior' have been entered");

            //Selecting 'Internal Services' from 'Any division' dropdown
            IWebElement element4 = driver.FindElement(By.XPath("//*[@id=\"careers-hero\"]/div/div[1]/div/div/form/div[1]/div[2]/div/div[1]"));
            element4.Click();
            IWebElement element5 = driver.FindElement(By.XPath("/html/body/section/div/div[1]/div/div/form/div[1]/div[2]/div/div[2]/div/div[6]"));
            element5.Click();
            Console.WriteLine("The 'Internal Services' option is slected from the 'Any division' dropdown");

            //Selecting 'Bulgaria' from 'Any country' dropdown
            IWebElement element6 = driver.FindElement(By.XPath("//*[@id=\"careers-hero\"]/div/div[1]/div/div/form/div[1]/div[3]/div/div[1]"));
            element6.Click();
            IWebElement element7 = driver.FindElement(By.XPath("//*[@id=\"careers-hero\"]/div/div[1]/div/div/form/div[1]/div[3]/div/div[2]/div/div[2]"));
            element7.Click();
            Console.WriteLine("The 'Bulgaria' option is slected from the 'Any country' dropdown");

            //Selecting 'Sofia' from 'Any location' dropdown
            IWebElement element8 = driver.FindElement(By.XPath("//*[@id=\"careers-hero\"]/div/div[1]/div/div/form/div[1]/div[4]/div/div[1]"));
            element8.Click();
            IWebElement element9 = driver.FindElement(By.XPath("//*[@id=\"careers-hero\"]/div/div[1]/div/div/form/div[1]/div[4]/div/div[2]/div/div[4]"));
            element9.Click();
            Console.WriteLine("The 'Sofia' option is slected from the 'Any location' dropdown");

            //Clicking on the 'Search' button
            IWebElement element10 = driver.FindElement(By.XPath("//*[@id=\"careers-hero\"]/div/div[1]/div/div/form/div[1]/div[5]/button"));
            element10.Click();
            Console.WriteLine("The 'Search' button of the page is found and has been clicked");

            Thread.Sleep(1000);
            ScrollDown(driver);
            Thread.Sleep(1000);

            //Clicking on the 'REFER NOW' button
            IWebElement element11 = driver.FindElement(By.XPath("/html/body/section[2]/div/div[2]/div[1]/div/div/div[2]/a"));
            element11.Click();
            Console.WriteLine("The 'REFER NOW' button of the page is found and has been clicked");

            driver.Quit();
        }
    }
}