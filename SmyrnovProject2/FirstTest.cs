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
    class FirstTest
    {
        IWebDriver driver ;
        private string login, password;

        [SetUp]
        public void StartBrowser()
        {
            login = "as0701866@gmail.com";
            password = "123qwe321ewq";
            driver = new ChromeDriver();
            driver.Url = "https://accounts.google.com";
        }

        [Test]
        public void LogInToGmailShouldWork()
        {
            driver.FindElement(By.Id("identifierId")).SendKeys(login);
            driver.FindElement(By.XPath("//span/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("input[type=password]")).SendKeys(password);
            driver.FindElement(By.XPath("//div/div/span/span")).Click();
            Thread.Sleep(2000);
            String message = driver.FindElement(By.CssSelector(".x7WrMb")).Text;
            Assert.AreEqual(message, "Добро пожаловать, Алексей Смирнов!");
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}
