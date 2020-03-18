using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class AlertBoxPageObject
    {
        public AlertBoxPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-119\"]/div/figure/img")]
        public IWebElement imgAlertBox { get; set; }
    }
}
