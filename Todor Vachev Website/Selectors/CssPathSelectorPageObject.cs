using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class CssPathSelectorPageObject
    {
        public CssPathSelectorPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#post-108 > div > figure > img")]
        public IWebElement imgCssSelector { get; set; }
    }
}
