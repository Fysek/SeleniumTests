using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTests.Todor_Vachev_Website
{
    class HomePageObject
    {
        public HomePageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-25 > a")]
        public IWebElement btnIntroduction { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-106 > a")]
        public IWebElement btnSelectors { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-35 > a")]
        public IWebElement btnSpecElements { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-57 > a")]
        public IWebElement btnTestCases { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-58 > a")]
        public IWebElement btnTestScenarios { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#menu-item-26 > a")]
        public IWebElement btnAbout { get; set; }

        public SelectorsPageObject ClickSelectorPage()
        {
            btnSelectors.Clicks();
            return new SelectorsPageObject();
        }
    }
}
