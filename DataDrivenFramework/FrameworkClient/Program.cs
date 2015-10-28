using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrameworkClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Url = "http://www.beingzero.in";


            // TODO:  Write Your Code Here


            Console.WriteLine("Will be Quitting Browser after 3 Seconds");
            Thread.Sleep(3 * 1000);

            driver.Quit();
        }
    }
}
