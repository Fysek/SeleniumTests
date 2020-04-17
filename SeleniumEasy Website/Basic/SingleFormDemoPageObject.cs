using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTests.SeleniumEasy_Website
{
    class SingleFormDemoPageObject
    {
        public SingleFormDemoPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "user-message")]
        public IWebElement txtMessageField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"get-input\"]/button")]
        public IWebElement btnShowMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"display\"]")]
        public IWebElement displayMessage { get; set; }

        [FindsBy(How = How.Id, Using = "sum1")]
        public IWebElement txtValueA { get; set; }

        [FindsBy(How = How.Id, Using = "sum2")]
        public IWebElement txtValueB { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"gettotal\"]/button")]
        public IWebElement btnGetTotal { get; set; }


    }
}
