using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{
    class DragDropPageObject
    {
        public DragDropPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "item1")]
        public IWebElement itemDrag1 { get; set; }

        [FindsBy(How = How.Id, Using = "item2")]
        public IWebElement itemDrag2 { get; set; }

        [FindsBy(How = How.Id, Using = "item3")]
        public IWebElement itemDrag3 { get; set; }

        [FindsBy(How = How.Id, Using = "item4")]
        public IWebElement itemDrag4 { get; set; }

        [FindsBy(How = How.Id, Using = "item5")]
        public IWebElement itemDrag5 { get; set; }

        public void DragOneElem(IWebElement From, IWebElement To)
        {
            Actions act = new Actions(PropertiesCollection.driver);
            act.DragAndDrop(From, To).Build().Perform();
        }


    }
}



