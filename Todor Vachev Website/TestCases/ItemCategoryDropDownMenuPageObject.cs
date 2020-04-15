using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class ItemCategoryDropDownMenuPageObject
    {
        public ItemCategoryDropDownMenuPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"post - 78\"]/div/figure/img")]
        public IWebElement imgDropDownMenu { get; set; }
    }
}
