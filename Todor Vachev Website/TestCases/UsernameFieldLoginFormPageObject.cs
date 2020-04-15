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
    }
}
