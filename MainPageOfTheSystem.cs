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
    public class MainPageOfTheSystem : PageObject
    {
        public MainPageOfTheSystem(IWebDriver driver, WebDriverWait wait, ExtentReports extent, ExtentTest test) : base(driver, wait, extent, test) { }

        // Elements of main page
        IWebElement searchBox => driver.FindElement(By.CssSelector("[data-test-selector = 'nav-search-input']"));
        IWebElement searchBtn => driver.FindElement(By.CssSelector("[aria-label = 'Type script']"));

        // Functions for tests
        public void SearchForTapeScript()
        {
            test = extent.CreateTest("Search For Type Script Repo");
            WaitUntilElementIsClickable(searchBox);
            TypeTextInElement(searchBox, "Type script");
            Thread.Sleep(2000);
            ClickOnElement(searchBtn);
            test.Log(Status.Pass, "The test 'SearchForTypeScriptRepo' passed successfully");
        }
    }
}

  