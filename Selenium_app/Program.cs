using System.Threading;
using OpenQA.Selenium;

namespace Selenium_app
{
    class Program
    {
        static void Main()
        {
            //System.setProperty("webdriver.chrome.driver", "/usr/local/bin/ChromeDriver/chromedriver");
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
           // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();

         //   driver.Manage().Timeouts().ImplicitWait.Milliseconds.(10, TimeUnit.SECONDS);
            driver.Url = "http://youtube.com";

            driver.FindElement(By.CssSelector("#search")).SendKeys("Денчик грудные");
            driver.FindElement(By.CssSelector("#search-icon-legacy > yt-icon")).Click();
            Thread.Sleep(10000);
            driver.Close();
        }
    }
}
