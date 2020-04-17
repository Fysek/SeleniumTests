using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class LoginFormPageObject
    {
        public LoginFormPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "userid")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Name, Using = "passid")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "repeatpassid")]
        public IWebElement txtRepeatPassword { get; set; }
    }
}
