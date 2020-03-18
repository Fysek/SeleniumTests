using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class DropDownMenuTestPageObject
    {
        public DropDownMenuTestPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.Name, Using = "DropDownTest")]
        public IWebElement ddlMenuTest { get; set; }
        public void SelectFromDDM(string label)
        {
            ddlMenuTest.SelectDropDown(label);
        }
    }
}
