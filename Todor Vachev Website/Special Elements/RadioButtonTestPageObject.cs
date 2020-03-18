using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class RadioButtonTestPageObject
    {
        public RadioButtonTestPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(1)")]
        public IWebElement btnRadioButton1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(3)")]
        public IWebElement btnRadioButton2 { get; set; }
    }
}
