using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace SeleniumTests
{
    class DemoTests
    {
        [SetUp]
        public void startBrowser()
        {
            PropertiesCollection.driver = new ChromeDriver("C:\\Users\\Dekimo\\Downloads\\chromedriver_win32");
            Console.WriteLine("Opened Chromedriver");
        }

        [Test]
        public void DemoGoogleTest()
        {
            PropertiesCollection.driver.Url = "http://www.google.co.in";
        }

        [Test]
        public void DemoAutomateGoogle()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement element = PropertiesCollection.driver.FindElement(By.Name("q"));
            element.SendKeys("execute automation");
        }

        [Test]
        public void DemoClickElement()
        {
            PropertiesCollection.driver.Url = "http://demo.guru99.com/test/guru99home/";
            PropertiesCollection.driver.Manage().Window.Maximize();
            IWebElement link = PropertiesCollection.driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
            link.Click();
        }

        [Test]
        public void DemoSelectElement()
        {
            PropertiesCollection.driver.Url = "http://demo.guru99.com/test/guru99home/";
            PropertiesCollection.driver.Manage().Window.Maximize();

            IWebElement course = PropertiesCollection.driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));

            var selectTest = new SelectElement(course);
            selectTest.SelectByValue("sap-abap");
        }

        [TearDown]
        public void closeBrowser()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
