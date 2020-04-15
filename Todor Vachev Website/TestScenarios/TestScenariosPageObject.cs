using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{ 
    class TestScenariosPageObject
    {
        public TestScenariosPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div[2]/header/h3/a")]
        public IWebElement btnLoginForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div[2]/header/h3/a")]
        public IWebElement btnRegisterForm { get; set; }
        public ItemCategoryDropDownMenuPageObject ClickItemCategoryDropDownMenuPage()
        {
            btnLoginForm.Clicks();
            return new ItemCategoryDropDownMenuPageObject();
        }
        public LoginButtonLoginFormPageObject ClickLoginButtonLoginFormPage()
        {
            btnRegisterForm.Clicks();
            return new LoginButtonLoginFormPageObject();
        }
    }
}
