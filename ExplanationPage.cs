using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using AventStack.ExtentReports;

namespace SepioExercise
{
    public class ExplanationPage : PageObject
    {
        public ExplanationPage(IWebDriver driver, WebDriverWait wait, ExtentReports extent, ExtentTest test) : base(driver, wait, extent, test) { }

        // Elements of explanation page
        IWebElement loginBtn => driver.FindElement(By.CssSelector("[class = 'HeaderMenu-link flex-shrink-0 no-underline']"));

        // Functions for tests
        public void ClickOnLoginInExplanationPage()
        {
            WaitUntilElementIsClickable(loginBtn);
            ClickOnElement(loginBtn);
        }
    }
}
