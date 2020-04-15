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
    }
}
