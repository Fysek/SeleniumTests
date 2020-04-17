using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTests.SeleniumEasy_Website
{
    class AjaxFormSubmitPageObject
    {
        public AjaxFormSubmitPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
    }
}
