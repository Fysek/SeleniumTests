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
using SeleniumTests.SeleniumEasy_Website;

namespace SeleniumTests
{
    class SeleniumEasyTests
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
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            HomePageObject homePage = new HomePageObject();
            homePage.ClickStartPractisingPage();

            Thread.Sleep(5000);
            Assert.Pass();
        }

        [Test]/*add proper wait*/
        public void ClickSimpleFormDemoPageTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            HomePageObject homePage = new HomePageObject();
            SingleFormDemoPageObject singleFormDemoPage = new SingleFormDemoPageObject();

            Thread.Sleep(1000);
            singleFormDemoPage = homePage.ClickSimpleFormDemoPage();
            Thread.Sleep(1000);
            singleFormDemoPage.txtMessageField.SendKeys("HelloWorld");
            Thread.Sleep(1000);
            singleFormDemoPage.btnShowMessage.Clicks();
            Thread.Sleep(1000);
            Assert.AreEqual(SeleniumGetMethods.GetText(singleFormDemoPage.txtMessageField), "HelloWorld");
        }

        [Test]/*add proper wait*/
        public void ClickSingleCheckBoxDemoPageTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            HomePageObject homePage = new HomePageObject();
            CheckBoxDemoPageObject checkBoxDemoPage = new CheckBoxDemoPageObject();
            Thread.Sleep(3000);
            checkBoxDemoPage = homePage.ClickCheckBoxDemoPage();
            Thread.Sleep(1000);
            checkBoxDemoPage.chkboxSingleBox.Clicks();
            Thread.Sleep(1000);
            Assert.AreEqual(checkBoxDemoPage.chkboxSingleBox.GetAttribute("checked"), "true");
        }

        [Test]/*add proper wait*/
        public void ClickMultipleCheckBoxDemoPageTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            HomePageObject homePage = new HomePageObject();
            CheckBoxDemoPageObject checkBoxDemoPage = new CheckBoxDemoPageObject();
            Thread.Sleep(1000);
            checkBoxDemoPage = homePage.ClickCheckBoxDemoPage();
            Thread.Sleep(1000);
            checkBoxDemoPage.chkboxOption1.Clicks();
            checkBoxDemoPage.chkboxOption2.Clicks();
            Thread.Sleep(1000);
            Assert.AreEqual(checkBoxDemoPage.btnCheckAll.GetAttribute("value"), "Check All");
        }

        [Test]/*add proper wait*/
        public void ClickMultipleUncheckBoxDemoPageTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            HomePageObject homePage = new HomePageObject();
            CheckBoxDemoPageObject checkBoxDemoPage = new CheckBoxDemoPageObject();
            Thread.Sleep(1000);
            checkBoxDemoPage = homePage.ClickCheckBoxDemoPage();
            Thread.Sleep(1000);
            checkBoxDemoPage.chkboxOption1.Clicks();
            Thread.Sleep(1000);
            checkBoxDemoPage.chkboxOption2.Clicks();
            Thread.Sleep(1000);
            checkBoxDemoPage.chkboxOption3.Clicks();
            Thread.Sleep(1000);
            checkBoxDemoPage.chkboxOption4.Clicks();
            Thread.Sleep(1000);
            Assert.AreEqual(checkBoxDemoPage.btnCheckAll.GetAttribute("value"), "Uncheck All");
        }

        [Test]/*add proper wait*/
        public void ClickSingleRadioButtonDemoPageTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            HomePageObject homePage = new HomePageObject();
            RadioButtonDemoPageObject radioButtonDemoPage = new RadioButtonDemoPageObject();

            Thread.Sleep(1000);
            radioButtonDemoPage = homePage.ClickRadioButtonDemoPage();
            Thread.Sleep(1000);
            radioButtonDemoPage.btnRadioMale.Clicks();
            radioButtonDemoPage.btnRadioFemale.Clicks();
            Thread.Sleep(1000);
            radioButtonDemoPage.btnCheckValue.Clicks();
            Assert.Pass();

        }

        [Test]/*add proper wait*/
        public void ClickGroupRadioButtonDemoPageTest()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            HomePageObject homePage = new HomePageObject();
            RadioButtonDemoPageObject radioButtonDemoPage = new RadioButtonDemoPageObject();

            Thread.Sleep(1000);
            radioButtonDemoPage = homePage.ClickRadioButtonDemoPage();
            Thread.Sleep(1000);
            radioButtonDemoPage.btnRadioSexFemale.Clicks();
            radioButtonDemoPage.btnRadioAge5to15.Clicks();
            Thread.Sleep(1000);
            radioButtonDemoPage.btnGetValues.Clicks();
            Assert.Pass();
        }

        [TearDown]
        public void closeBrowser()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
