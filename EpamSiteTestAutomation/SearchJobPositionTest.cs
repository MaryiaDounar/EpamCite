using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using EpamSite.Steps;
using EpamSite.Driver;

namespace EpamSiteTestAutomation
{
    [TestClass]
    public class SearchJobPositionTest
    {
        public Steps steps = new Steps();

        [TestMethod]
        public void SearchJobPosition()
        {
            steps.InitBrowser();
            steps.OpenCareersPage();
            steps.SearchJobPosition("Administrative positions", "Minsk");
            Assert.IsTrue(steps.IsSearchResultFounded("Accountant"));
            steps.CloseBrowser();
        }

    }
}
