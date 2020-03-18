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
        public void AlertBoxTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            HomePageObject homePage = new HomePageObject();
            SpecialElementsPageObject specialElementsPage = new SpecialElementsPageObject();
            AlertBoxPageObject alertBoxPage = new AlertBoxPageObject();

            specialElementsPage = homePage.ClickSpecialElementsPage();
            alertBoxPage = specialElementsPage.ClickAlertBoxTestPage();

            IAlert alert = PropertiesCollection.driver.SwitchTo().Alert();

            alert.Accept();

            Thread.Sleep(5000);

            if (alertBoxPage.imgAlertBox.Displayed)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TextInputFieldTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            HomePageObject homePage = new HomePageObject();
            SpecialElementsPageObject specialElementsPage = new SpecialElementsPageObject();
            TextInputFieldPageObject textInputFieldPage = new TextInputFieldPageObject();

            specialElementsPage = homePage.ClickSpecialElementsPage();
            textInputFieldPage = specialElementsPage.ClickTextInputFieldTestPage();

            textInputFieldPage.txtTextField.SendKeys("Hello there");
           
            Console.WriteLine(textInputFieldPage.txtTextField.GetAttribute("value"));
        }

        [Test]
        public void CheckButtonTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            HomePageObject homePage = new HomePageObject();
            SpecialElementsPageObject specialElementsPage = new SpecialElementsPageObject();
            CheckButtonTestPageObject checkButtonTestPage = new CheckButtonTestPageObject();

            specialElementsPage = homePage.ClickSpecialElementsPage();
            checkButtonTestPage = specialElementsPage.ClickCheckButtonTestPage();
            
            checkButtonTestPage.btnCheckBox1.Click();

            if (checkButtonTestPage.btnCheckBox1.GetAttribute("checked") == "true")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

            if (checkButtonTestPage.btnCheckBox2.GetAttribute("checked") == "true")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
            
            checkButtonTestPage.btnCheckBox2.Click();

        }

        [Test]
        public void RadioButtonTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            HomePageObject homePage = new HomePageObject();
            SpecialElementsPageObject specialElementsPage = new SpecialElementsPageObject();
            RadioButtonTestPageObject radioButtonTestPage = new RadioButtonTestPageObject();

            specialElementsPage = homePage.ClickSpecialElementsPage();
            radioButtonTestPage = specialElementsPage.ClickRadioButtonTestPage();    

            if (radioButtonTestPage.btnRadioButton1.GetAttribute("checked") == "true")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }    

            if (radioButtonTestPage.btnRadioButton2.GetAttribute("checked") == "false")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

            radioButtonTestPage.btnRadioButton2.Click();

            if (radioButtonTestPage.btnRadioButton2.GetAttribute("checked") == "true")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void DropDownMenuTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            HomePageObject homePage = new HomePageObject();
            SpecialElementsPageObject specialElementsPage = new SpecialElementsPageObject();
            DropDownMenuTestPageObject dropDownMenuTestPage = new DropDownMenuTestPageObject();

            specialElementsPage = homePage.ClickSpecialElementsPage();
            dropDownMenuTestPage = specialElementsPage.ClickDropDownMenuTestPage();

            dropDownMenuTestPage.SelectFromDDM("Audi");
        }

        [TearDown]
        public void closeBrowser()
        {
            PropertiesCollection.driver.Close();
        }

    }
}
