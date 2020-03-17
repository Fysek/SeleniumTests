using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    public static class SeleniumSetMethods
    {
        /// <summary>
        /// Extended method for entering text    
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement element, string value) 
        {
            element.SendKeys(value);
        }

        /// <summary>
        /// Extended method to click
        /// </summary>
        /// <param name="element"></param>
        public static void Clicks(this IWebElement element) 
        {
            element.Click();  
        }

        /// <summary>
        /// Extended method for selecting the text
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectDropDown(this IWebElement element, string value)
        { 
            new SelectElement(element).SelectByText(value);
        }
    }
}
