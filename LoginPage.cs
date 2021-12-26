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
    class LoginPage : PageObject
    {
        public LoginPage(IWebDriver driver, WebDriverWait wait, ExtentReports extent, ExtentTest test) : base(driver, wait, extent, test) { }

        // Elements of log in page
        IWebElement username => driver.FindElement(By.Id("login_field"));
        IWebElement password => driver.FindElement(By.Id("password"));
        IWebElement signInBtn => driver.FindElement(By.Name("commit"));
        // Functions for tests
        public void LoginToSystem()
        {
        {
            test = extent.CreateTest("Login Test");
            WaitUntilElementIsClickable(signInBtn);
            TypeTextInElement(username,"Amird220220@gmail.com");
            test.Log(Status.Info, "User name: Amird220220@gmail.com was entered");
            TypeTextInElement(password, "Aa7703668");
            test.Log(Status.Info, "Password: Aa7703668 was entered");
            ClickOnElement(signInBtn);
            test.Log(Status.Pass, "The test 'LoginToSystem' passed successfully");
        }
    }
}
