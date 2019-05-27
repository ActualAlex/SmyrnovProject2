using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmyrnovProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm");


            IWebDriver driver = new ChromeDriver(); // передаем путь до chromedriver.exe
            {
                driver.Navigate().GoToUrl("https://google.com/");

                driver.Quit();
            }
        }
    }
}
