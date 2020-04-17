using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTests.SeleniumEasy_Website
{
    class HomePageObject
    {
        public HomePageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "btn_basic_example")]
        public IWebElement btnStartPractise { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"basic_example\"]/span/i")]
        public IWebElement btnBasic { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"inter_example\"]/span/i")]
        public IWebElement btnIntermediate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"advanced_example\"]/span/i")]
        public IWebElement btnAdvanced { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"basic\"]/div/a[1]")]
        public IWebElement btnSimpleFormDemo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"basic\"]/div/a[2]")]
        public IWebElement btnCheckBoxDemo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"basic\"]/div/a[3]")]
        public IWebElement btnRadioButtonsDemo { get; set; }

        public void ClickStartPractisingPage()
        {
            btnStartPractise.Clicks();
        }
        public SingleFormDemoPageObject ClickSimpleFormDemoPage()
        {
            btnBasic.Clicks();
            btnSimpleFormDemo.Clicks();
            return new SingleFormDemoPageObject();
        }
        public CheckBoxDemoPageObject ClickCheckBoxDemoPage()
        {
            btnBasic.Clicks();
            Thread.Sleep(1000);
            btnCheckBoxDemo.Clicks();
            return new CheckBoxDemoPageObject();
        }
        public RadioButtonDemoPageObject ClickRadioButtonDemoPage()
        {
            btnBasic.Clicks();
            Thread.Sleep(1000);
            btnRadioButtonsDemo.Clicks();
            return new RadioButtonDemoPageObject();
        }

    }
}
