using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTests.SeleniumEasy_Website
{
    class RadioButtonDemoPageObject
    {
        public RadioButtonDemoPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"easycont\"]/div/div[2]/div[1]/div[2]/label[1]")]
        public IWebElement btnRadioMale { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"easycont\"]/div/div[2]/div[1]/div[2]/label[2]")]
        public IWebElement btnRadioFemale { get; set; }

        [FindsBy(How = How.Id, Using = "buttoncheck")]
        public IWebElement btnCheckValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"easycont\"]/div/div[2]/div[2]/div[2]/div[1]/label[1]")]
        public IWebElement btnRadioSexMale { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"easycont\"]/div/div[2]/div[2]/div[2]/div[1]/label[2]")]
        public IWebElement btnRadioSexFemale { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"easycont\"]/div/div[2]/div[2]/div[2]/div[2]/label[1]")]
        public IWebElement btnRadioAge0to5 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"easycont\"]/div/div[2]/div[2]/div[2]/div[2]/label[2]")]
        public IWebElement btnRadioAge5to15 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"easycont\"]/div/div[2]/div[2]/div[2]/div[2]/label[3]")]
        public IWebElement btnRadioAge15to20 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"easycont\"]/div/div[2]/div[2]/div[2]/button")]
        public IWebElement btnGetValues { get; set; }
    }
}
