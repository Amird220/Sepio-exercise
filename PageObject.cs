using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SepioExercise
{
    public class PageObject
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        public static ExtentReports extent;
        public static ExtentTest test;

        public PageObject(IWebDriver _driver, WebDriverWait _wait, ExtentReports _extent, ExtentTest _test)
        {
            driver = _driver;
            wait = _wait;
            extent = _extent;
            test = _test;
        }

        // General Functions
        public void ClickOnElement(IWebElement element)
        {
            element.Click();
        }
        public void TypeTextInElement(IWebElement element, string input)
        {
            element.SendKeys(input);
        }
        public void ClearTextOfElement(IWebElement element)
        {
            element.Clear();
        }

        public void WaitUntilElementIsClickable(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}