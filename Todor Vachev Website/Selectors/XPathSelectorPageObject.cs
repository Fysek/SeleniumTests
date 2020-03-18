using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class XPathSelectorPageObject
    {
        public XPathSelectorPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-109\"]/div/figure/img")]
        public IWebElement imgXPathSelector { get; set; }
    }
}
