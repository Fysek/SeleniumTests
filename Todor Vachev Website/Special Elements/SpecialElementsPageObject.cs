using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests.Todor_Vachev_Website
{
    class SpecialElementsPageObject
    {
        public SpecialElementsPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[1]/div[2]/header/h3/a")]
        public IWebElement btnAlertBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[2]/div[2]/header/h3/a")]
        public IWebElement btnTextInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[3]/div[2]/header/h3/a")]
        public IWebElement btnCheckButtonTest { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[4]/div[2]/header/h3/a")]
        public IWebElement btnRadioButtonTest { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/article[5]/div[2]/header/h3/a")]
        public IWebElement btnDropDownMenuTest { get; set; }
       
        public AlertBoxPageObject ClickAlertBoxTestPage()
        {
            btnAlertBox.Clicks();
            return new AlertBoxPageObject();
        }
        public TextInputFieldPageObject ClickTextInputFieldTestPage()
        {
            btnTextInputField.Clicks();
            return new TextInputFieldPageObject();
        }
        public CheckButtonTestPageObject ClickCheckButtonTestPage()
        {
            btnCheckButtonTest.Clicks();
            return new CheckButtonTestPageObject();
        }
        public RadioButtonTestPageObject ClickRadioButtonTestPage()
        {
            btnRadioButtonTest.Clicks();
            return new RadioButtonTestPageObject();
        }
        public DropDownMenuTestPageObject ClickDropDownMenuTestPage()
        {
            btnDropDownMenuTest.Clicks();
            return new DropDownMenuTestPageObject();
        }
    }
}

