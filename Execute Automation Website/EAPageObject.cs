using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace SeleniumTests
{
    class EAPageObject
    {
        public EAPageObject()
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

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='Dragging.html']")]
        public IWebElement btnDragAndDrop { get; set; }

        [FindsBy(How = How.Name, Using = "english")]
        public IWebElement chboxEnglish { get; set; }

        [FindsBy(How = How.Name, Using = "Hindi")]
        public IWebElement chboxHindi { get; set; }

        [FindsBy(How = How.Id, Using = "Automation Tools")]
        public IWebElement btnAutomationToolsFromMenu { get; set; }

        [FindsBy(How = How.Id, Using = "Selenium")]
        public IWebElement btnSeleniumFromMenu { get; set; }

        [FindsBy(How = How.Id, Using = "Selenium WebDriver")]
        public IWebElement btnSelectWebDriverFromMenu { get; set; }

        [FindsBy(How = How.Name, Using = "generate")]
        public IWebElement btnGenerateJSALert { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='popup.html']")]
        public IWebElement btnPopup { get; set; }


        public void FillUserForm(string initial, string firstName, string middleName)
        {
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            btnSave.Clicks();
        }
        public void FillFullForm(string title, string initial, string firstName, string middleName)
        {
            ddlTitleID.SelectDropDown(title);
            txtInitial.EnterText(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            chboxEnglish.Clicks();
            chboxHindi.Clicks();
            btnSave.Clicks();
        }
        public DragDropPageObject DragDropPageClick()
        {
            btnDragAndDrop.Clicks();
            return new DragDropPageObject();
        }

        public void SelectSeleniumWebDriverFromMenu()
        {
            btnAutomationToolsFromMenu.Click();
            Thread.Sleep(2000);
            btnSeleniumFromMenu.Click();
            Thread.Sleep(2000);
            btnSelectWebDriverFromMenu.Click();
        }

        public HTMLPopupPageObject ClickHMTLPopup() 
        {
            btnPopup.Clicks();
            return new HTMLPopupPageObject();
        }

    }
}
