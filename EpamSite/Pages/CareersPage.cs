using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using EpamSite.Driver;

namespace EpamSite.Pages
{
   public  class CareersPage : AbstractPage
    {
       private const string URL = "http://www.epam.com/careers";
       private IWebDriver driver;

       public CareersPage()
       {
           driver = DriverInstance.GetInstance();
       }

       public override void OpenPage()
       {
           driver.Navigate().GoToUrl(URL);
       }

       public void SelectJobPosition(string job)
       {
           IWebElement jobPosition = driver.FindElement(By.Id("department-select"));
           MakeElementVisible(jobPosition);
           SelectElement selectJobPosition = new SelectElement(jobPosition);
           selectJobPosition.SelectByValue(job);
       }

       public void SelectLocation(string location)
       {
           IWebElement jobLocation = driver.FindElement(By.Id("location-select"));
           MakeElementVisible(jobLocation);
           SelectElement selectJobLocation = new SelectElement(jobLocation);
           selectJobLocation.SelectByValue(location);
       }

       private void MakeElementVisible(IWebElement element)
       {
           ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].removeAttribute('style');", element);
       }

       public void SearchJob()
       {
           IWebElement buttonSearchJob = driver.FindElement(By.XPath("//button[@value = 'search']"));
           buttonSearchJob.Click();
       }

       public bool IsSearchResultsDisplayed(string FirstResult)
       {
           IWebElement firstResult = driver.FindElement(By.XPath("//a[text()='Accountant']"));
           return IsElementDisplayed(firstResult);
       }

      
    }
}
