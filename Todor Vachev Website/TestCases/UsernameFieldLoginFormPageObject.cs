using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class UsernameFieldLoginFormPageObject
    {
        public UsernameFieldLoginFormPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-74\"]/div/figure/img")]
        public IWebElement imgUsernameField { get; set; }
    }
}
