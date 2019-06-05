using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmyrnovProject2
{
    class SecondTest
    {

        IWebDriver driver;
        private string login;

        [SetUp]
        public void StartBrowser()
        {
            login = "qwe@gmail.com";
            driver = new ChromeDriver();
            driver.Url = "https://accounts.google.com";

        }

        [Test]
        public void LogInToGmailWithIncorrectMailShouldNotWork()
        {
            driver.FindElement(By.Id("identifierId")).SendKeys(login);
            driver.FindElement(By.XPath("//span/span")).Click();
            Thread.Sleep(2000);
            String message = driver.FindElement(By.CssSelector(".GQ8Pzc")).Text;
            Assert.AreEqual(message, "Не удалось найти аккаунт Google");
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
