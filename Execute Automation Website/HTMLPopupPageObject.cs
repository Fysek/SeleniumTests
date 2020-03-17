using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{
    class HTMLPopupPageObject
    {
        public HTMLPopupPageObject()
        {

            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "LastName")]
        public IWebElement txtLastName { get; set; }

        [FindsBy(How = How.Id, Using = "Country")]
        public IWebElement ddlCountry { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }
        public void FillUserForm(string title, string initial, string firstName, string middleName, string lastName)
        {
            ddlTitleID.SelectDropDown(title);
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            txtLastName.EnterText(lastName);
            btnSave.Clicks();
        }


    }
}
