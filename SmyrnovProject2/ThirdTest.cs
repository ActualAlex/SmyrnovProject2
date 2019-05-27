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
    class ThirdTest
    {
        IWebDriver driver;
        private string login, password;

        [SetUp]
        public void StartBrowser()
        {
            login = "as0701866@gmail.com";
            password = "123";
            driver = new ChromeDriver();
            driver.Url = "https://accounts.google.com";

        }

        [Test]
        public void LogInToGmailWithIncorrectPasswordShouldNotWork()
        {
            driver.FindElement(By.Id("identifierId")).SendKeys(login);
            driver.FindElement(By.XPath("//content/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("input[type=password]")).SendKeys(password);
            driver.FindElement(By.XPath("//div/div/content/span")).Click();
            Thread.Sleep(2000);
            string message = driver.FindElement(By.CssSelector(".GQ8Pzc")).Text;
            Assert.AreEqual(message, "Неверный пароль. Повторите попытку или нажмите на ссылку \"Забыли пароль?\", чтобы сбросить его.");
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
