using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
namespace SepioExercise
{
    public class BaseTest 
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        public static ExtentReports extent;
        public static ExtentTest test;

        public const string GIT_HUB_URL = "https://github.com/";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // Initialize driver and wait 
            driver = new ChromeDriver(@"C:\Users\User\Desktop\Automation exercises\ChromeDriver");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Initialize extent report
            extent = new ExtentReports();
            var htmlreporter = new ExtentSparkReporter(@"C:\Users\User\Desktop\Automation exercises\Reprts\" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");
            extent.AttachReporter(htmlreporter);

            ExplanationPage explanationPage = new ExplanationPage(driver, wait, extent, test);
            LoginPage loginPage = new LoginPage(driver, wait, extent, test);
            MainPageOfTheSystem mainPageOfTheSystem = new MainPageOfTheSystem(driver, wait, extent, test);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(GIT_HUB_URL);
            explanationPage.ClickOnLoginInExplanationPage();
            loginPage.LoginToSystem();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
            extent.Flush();
        }
    }
}
