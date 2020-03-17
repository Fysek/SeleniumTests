using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumTests.Todor_Vachev_Website
{
    enum SelectorType
    {
        Name,
        Id,
        XPath,
        CssPath,
        ClassName
    }

    class SelectorsPageObject
    {
        public SelectorsPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main - content\"]/article[1]/div[2]/header/h3/a")]
        public IWebElement btnNameSelector { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main - content\"]/article[2]/div[2]/header/h3/a")]
        public IWebElement btnIdSelector { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main - content\"]/article[3]/div[2]/header/h3/a")]
        public IWebElement btnXPathSelector { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main - content\"]/article[4]/div[2]/header/h3/a")]
        public IWebElement btnCssPathSelector { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main - content\"]/article[5]/div[2]/header/h3/a")]
        public IWebElement btnClassNameSelector { get; set; }

        public NameSelectorPageObject ClickNameSelectorPage()
        {
            btnNameSelector.Clicks();
            return new NameSelectorPageObject();
        }
        public IdSelectorPageObject ClickIdSelectorPage()
        {
            btnIdSelector.Clicks();
            return new IdSelectorPageObject();
        }
        public XPathSelectorPageObject ClickXPathSelectorPage()
        {
            btnXPathSelector.Clicks();
            return new XPathSelectorPageObject();
        }
        public CssPathSelectorPageObject ClickCssPathSelectorPage()
        {
            btnCssPathSelector.Clicks();
            return new CssPathSelectorPageObject();
        }
        public ClassNameSelectorPageObject ClickClassNameSelectorPage()
        {
            btnClassNameSelector.Clicks();
            return new ClassNameSelectorPageObject();
        }

    }
}
