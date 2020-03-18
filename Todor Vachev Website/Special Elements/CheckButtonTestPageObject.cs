using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class CheckButtonTestPageObject
    {
        public CheckButtonTestPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(1)")]
        public IWebElement btnCheckBox1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(3)")]
        public IWebElement btnCheckBox2 { get; set; }
    }
}
