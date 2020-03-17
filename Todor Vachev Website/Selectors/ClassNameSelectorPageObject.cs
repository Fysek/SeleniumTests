using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class ClassNameSelectorPageObject
    {
        public ClassNameSelectorPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.ClassName, Using = "testClass")]
        public IWebElement txtParagraph { get; set; }
    }
}
