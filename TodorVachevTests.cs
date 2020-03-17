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
using System.Threading;
using SeleniumTests.Todor_Vachev_Website;
namespace SeleniumTests
{
    class TodorVachevTests
    {
        [SetUp]
        public void startBrowser()
        {
            PropertiesCollection.driver = new ChromeDriver("C:\\Users\\Dekimo\\Downloads\\chromedriver_win32");
            Console.WriteLine("Opened Chromedriver");
        }

        [Test]
        public void ClickSelectorPage()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            HomePageObject homePage = new HomePageObject();
            SelectorsPageObject selectorPage = new SelectorsPageObject();
            selectorPage = homePage.ClickSelectorPage();
            Thread.Sleep(5000);
            Assert.Pass();
        }

        [Test]
        public void FindByName()
        {      
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com");
            
            HomePageObject homePage = new HomePageObject();
            SelectorsPageObject selectorPage = new SelectorsPageObject();
            NameSelectorPageObject nameSelectorPage = new NameSelectorPageObject();

            selectorPage = homePage.ClickSelectorPage();
            nameSelectorPage = selectorPage.ClickNameSelectorPage();

             
            if (nameSelectorPage.txtNameBox.Displayed)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]
        public void FindById()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            HomePageObject homePage = new HomePageObject();
            SelectorsPageObject selectorPage = new SelectorsPageObject();
            IdSelectorPageObject idSelectorPage = new IdSelectorPageObject();

            selectorPage = homePage.ClickSelectorPage();
            idSelectorPage = selectorPage.ClickIdSelectorPage();

            if (idSelectorPage.imgIDSelector.Displayed)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]
        public void FindByXPath()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            HomePageObject homePage = new HomePageObject();
            SelectorsPageObject selectorPage = new SelectorsPageObject();
            XPathSelectorPageObject xPathSelectorPage = new XPathSelectorPageObject();

            selectorPage = homePage.ClickSelectorPage();
            xPathSelectorPage = selectorPage.ClickXPathSelectorPage();

            if (xPathSelectorPage.imgXPathSelector.Displayed)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void FindByCssPath()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            HomePageObject homePage = new HomePageObject();
            SelectorsPageObject selectorPage = new SelectorsPageObject();
            CssPathSelectorPageObject cssPathSelectorPage = new CssPathSelectorPageObject();

            selectorPage = homePage.ClickSelectorPage();
            cssPathSelectorPage = selectorPage.ClickCssPathSelectorPage();

            if (cssPathSelectorPage.imgCssSelector.Displayed)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void FindByCssPathNoElement()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            HomePageObject homePage = new HomePageObject();
            SelectorsPageObject selectorPage = new SelectorsPageObject();
            CssPathSelectorPageObject cssPathSelectorPage = new CssPathSelectorPageObject();

            selectorPage = homePage.ClickSelectorPage();
            cssPathSelectorPage = selectorPage.ClickCssPathSelectorPage();

            IWebElement element;

            try
            {
                element = PropertiesCollection.driver.FindElement(By.CssSelector("#post-108 > div > fig img"));

                if (element.Displayed)
                {
                    Assert.Pass();
                }
                else
                {
                    Assert.Fail();
                }

            }
            catch (NoSuchElementException)
            {
            }
        }

        [Test]
        public void FindByClassName()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            HomePageObject homePage = new HomePageObject();
            SelectorsPageObject selectorPage = new SelectorsPageObject();
            ClassNameSelectorPageObject classNameSelectorPage = new ClassNameSelectorPageObject();

            selectorPage = homePage.ClickSelectorPage();
            classNameSelectorPage = selectorPage.ClickClassNameSelectorPage();

            if (classNameSelectorPage.txtParagraph.Displayed)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TextBoxTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com/special-elements/text-input-field/");

            IWebElement textBox = PropertiesCollection.driver.FindElement(By.Name("username"));

            textBox.SendKeys("Hello there");

            Console.WriteLine(textBox.GetAttribute("value"));
        }

        [Test]
        public void CheckBoxTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com/special-elements/check-button-test-3/");

            IWebElement checkBox1 = PropertiesCollection.driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(1)"));
            IWebElement checkBox2 = PropertiesCollection.driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(3)"));

            if (checkBox1.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Checked");
            }
            else
            {
                Console.WriteLine("Not checked");
            }

            checkBox2.Click();
            Thread.Sleep(5000);

        }

        [Test]
        public void RadioButtonTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com/special-elements/radio-button-test/");

            IWebElement radioButton1 = PropertiesCollection.driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(1)"));
            IWebElement radioButton2 = PropertiesCollection.driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(3)"));

            if (radioButton1.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Checked");
            }
            else
            {
                Console.WriteLine("Not checked");
            }
            radioButton2.Click();
            Thread.Sleep(5000);
        }

        [Test]
        public void DropDownMenuTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com/special-elements/drop-down-menu-test/");

            IWebElement radioButton1 = PropertiesCollection.driver.FindElement(By.Name("DropDownTest"));

            if (radioButton1.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Checked");
            }
            else
            {
                Console.WriteLine("Not checked");
            }

            Thread.Sleep(5000);
        }

        [Test]
        public void AlertBoxTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com/special-elements/alert-box/");

            IAlert alert = PropertiesCollection.driver.SwitchTo().Alert();

            alert.Accept();

            Thread.Sleep(5000);
        }

        [TearDown]
        public void closeBrowser()
        {
            PropertiesCollection.driver.Close();
        }

    }
}
