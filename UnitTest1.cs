using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace radio_button
{
    class radio
    {

        IWebDriver driver;

        [SetUp]

        public void start_Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }


        [Test]

        public void test_search()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://dovydenas.lt/sandboxone");

            driver.Manage().Window.Maximize();

            //driver.FindElement(By.XPath("//div[text() = 'My Cart']")).Click();

            //System.Threading.Thread.Sleep(2000);

            IWebElement field = driver.FindElement(By.Id("search"));

            field.SendKeys("testproduct");
            System.Threading.Thread.Sleep(2000);


            IWebElement button = driver.FindElement(By.XPath("//*[@id='search_mini_form']/div/button"));
            button.Click();

            System.Threading.Thread.Sleep(2000);


            // IWebElement button = driver.FindElement(By.Id("search_mini_form"));

            //System.Threading.Thread.Sleep(2000);

            // button.Click();




            string classes = button.GetAttribute("class");


            Console.WriteLine("Test Passed");



        }

        [TearDown]

        public void close_Browser()
        {
            driver.Quit();
        }
    }
}
