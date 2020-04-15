using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class LoginButtonLoginFormPageObject
    {
        public LoginButtonLoginFormPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.Name, Using = "testButton")]
        public IWebElement btnRegButton { get; set; }
    }
}
