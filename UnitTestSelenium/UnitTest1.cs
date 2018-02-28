using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UnitTestSelenium
{
    [TestFixture]
    public class UnitTest1
    {

        private  IWebDriver _driver;
        private  WebDriverWait _wait;

        [SetUp]
        public void Start()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Manage().Window.Maximize();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void TestMethod1()
        {
            _driver.Url = "http://youtube.com";
            _driver.FindElement(By.CssSelector("#search")).SendKeys("Денчик грудные");
            _driver.FindElement(By.CssSelector("#search-icon-legacy > yt-icon")).Click();
            _wait.Timeout = TimeSpan.FromSeconds(100);
        }

        [TearDown]
        public void Stop()
        {
            _driver.Quit();
            _driver = null;
        }

    }
}
