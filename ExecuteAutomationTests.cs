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
    class ExecuteAutomationTests
    {

        [SetUp]
        public void startBrowser()
        {
            PropertiesCollection.driver = new ChromeDriver("C:\\Users\\Dekimo\\Downloads\\chromedriver_win32");
            Console.WriteLine("Opened Chromedriver");
        }

        [Test]
        public void PageObjectAutomationSite()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");

            EAPageObject page = new EAPageObject();

            page.txtInitial.SendKeys("executeautomation");

            page.btnSave.Click();
        }

        [Test]
        public void LoginAutomationSite()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

            LoginPageObject pageLogin = new LoginPageObject();
         
            EAPageObject pageEA = pageLogin.Login("execute", "automation");
         
            pageEA.FillUserForm("MD", "Maats", "Dijk");
        }

        [Test]
        public void LoginAndFillAutomationSite()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

            LoginPageObject pageLogin = new LoginPageObject();

            EAPageObject pageEA = pageLogin.Login("execute", "automation");
           
            pageEA.FillFullForm("Mr.","MD", "Maats", "Dijk");
        }

        [Test]
        public void LoginAndFillCheckSite()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

            LoginPageObject pageLogin = new LoginPageObject();

            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(15));

            IWebElement input = wait.Until<IWebElement>(d => d.FindElement(By.Name("TitleId")));

            pageEA.FillFullForm("Mr.", "MD", "Maats", "Dijk");

            IWebElement element = PropertiesCollection.driver.FindElement(By.Name("TitleId"));

            Assert.AreEqual(SeleniumGetMethods.GetTextFromDDL(element), "Mr.", "Wrong prefix chosen");

            element = PropertiesCollection.driver.FindElement(By.Name("Initial"));

            Assert.AreEqual(SeleniumGetMethods.GetText(element), "MD");

            element = PropertiesCollection.driver.FindElement(By.Name("FirstName"));

            Assert.AreEqual(SeleniumGetMethods.GetText(element), "Maats");

            element = PropertiesCollection.driver.FindElement(By.Name("MiddleName"));

            Assert.AreEqual(SeleniumGetMethods.GetText(element), "Dijk");
        }

        [Test]
        public void DragAndDropAction()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

            LoginPageObject pageLogin = new LoginPageObject();
            
            EAPageObject pageEA = pageLogin.Login("execute", "automation");
            
            DragDropPageObject pageDragDrop = pageEA.DragDropPageClick();

            pageDragDrop.DragOneElem(pageDragDrop.itemDrag2, pageDragDrop.itemDrag5);
            
            pageDragDrop.DragOneElem(pageDragDrop.itemDrag1, pageDragDrop.itemDrag5);           
        }


        [Test]
        public void ClickToAutomationSite()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

            LoginPageObject pageLogin = new LoginPageObject();
           
            EAPageObject pageEA = pageLogin.Login("execute", "automation");
            
            pageEA.SelectSeleniumWebDriverFromMenu();
        }

        [Test]
        public void AlertJSTestAccept()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

            LoginPageObject pageLogin = new LoginPageObject();

            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            pageEA.btnGenerateJSALert.Click();

            IAlert simpleAlert = PropertiesCollection.driver.SwitchTo().Alert();
            Thread.Sleep(3000);
            String alertText = simpleAlert.Text;
            Console.WriteLine("Alert text is " + alertText);

            Thread.Sleep(3000);
            simpleAlert.Accept();

            Thread.Sleep(3000);
            alertText = simpleAlert.Text;
            Console.WriteLine("Alert text is " + alertText);

            simpleAlert.Accept();
        }

        [Test]
        public void AlertJSTestDismiss()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

            LoginPageObject pageLogin = new LoginPageObject();

            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            pageEA.btnGenerateJSALert.Click();

            IAlert simpleAlert = PropertiesCollection.driver.SwitchTo().Alert();
            Thread.Sleep(3000);
            String alertText = simpleAlert.Text;
            Console.WriteLine("Alert text is " + alertText);

            Thread.Sleep(3000);
            simpleAlert.Dismiss();

            Thread.Sleep(3000);
            alertText = simpleAlert.Text;
            Console.WriteLine("Alert text is " + alertText);

            simpleAlert.Accept();
        }

        [Test]
        public void ClickHMTLPopup()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");

            LoginPageObject pageLogin = new LoginPageObject();

            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            HTMLPopupPageObject pageHTMLPopup = pageEA.ClickHMTLPopup();

            //Change handler to second window
            PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles[1]);
            
            //Fill form
            pageHTMLPopup.FillUserForm("Mr.", "MD", "Maats", "Dijk", "Doode");
            
            //Close the popup window
            PropertiesCollection.driver.Close();

            //Switch handler to main window
            PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles[0]);
        }

        [TearDown] 
        public void closeBrowser()
        {
            PropertiesCollection.driver.Close();
        }

        
    }
}
