using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;

namespace SepioExercise
{
    class MainScreenOfSystemTests : BaseTest
    {
        public MainScreenOfSystemTests() : base() { }

        [Test]
        public void SearchForTypeScriptRepo()
        {
            MainPageOfTheSystem mainPage = new MainPageOfTheSystem(driver, wait, extent, test);
            mainPage.SearchForTapeScript();
        }
    }
}
