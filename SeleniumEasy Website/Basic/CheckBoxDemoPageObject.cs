using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTests.SeleniumEasy_Website
{
    class CheckBoxDemoPageObject
    {
        public CheckBoxDemoPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "isAgeSelected")]
        public IWebElement chkboxSingleBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"easycont\"]/div/div[2]/div[2]/div[2]/div[1]/label")]
        public IWebElement chkboxOption1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"easycont\"]/div/div[2]/div[2]/div[2]/div[2]/label")]
        public IWebElement chkboxOption2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"easycont\"]/div/div[2]/div[2]/div[2]/div[3]/label")]
        public IWebElement chkboxOption3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"easycont\"]/div/div[2]/div[2]/div[2]/div[4]/label")]
        public IWebElement chkboxOption4 { get; set; }

        [FindsBy(How = How.Id, Using = "check1")]
        public IWebElement btnCheckAll{ get; set; }
    }
}
