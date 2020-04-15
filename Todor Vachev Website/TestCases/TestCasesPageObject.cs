using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class TestCasesPageObject
    {
        public TestCasesPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div[2]/header/h3/a")]
        public IWebElement btnItemsDropDownMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div[2]/header/h3/a")]
        public IWebElement btnLoginBtnLoginForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div[2]/header/h3/a")]
        public IWebElement btnUsernameFieldLoginForm { get; set; }

        public ItemCategoryDropDownMenuPageObject ClickItemCategoryDropDownMenuPage()
        {
            btnItemsDropDownMenu.Clicks();
            return new ItemCategoryDropDownMenuPageObject();
        }
        public LoginButtonLoginFormPageObject ClickLoginButtonLoginFormPage()
        {
            btnLoginBtnLoginForm.Clicks();
            return new LoginButtonLoginFormPageObject();
        }
        public UsernameFieldLoginFormPageObject ClickUsernameFieldLoginFormPage()
        {
            btnUsernameFieldLoginForm.Clicks();
            return new UsernameFieldLoginFormPageObject();
        }

    }
}
