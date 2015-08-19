using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using EpamSite.Driver;
using EpamSite.Pages;

namespace EpamSite.Steps
{
   public class Steps
    {
       private IWebDriver driver;

       public void InitBrowser()
       {
           driver = DriverInstance.GetInstance();
       }

       public void CloseBrowser()
       {
           DriverInstance.CloseBrowser();
       }

       public void OpenCareersPage()
       {
           CareersPage careersPage = new CareersPage();
           careersPage.OpenPage();

       }

       public void SearchJobPosition(string job, string location)
       {
           CareersPage careersPage = new CareersPage();
           careersPage.SelectJobPosition(job);
           careersPage.SelectLocation(location);
           careersPage.SearchJob();
       }

       public bool IsSearchResultFounded(string firstResult)
       {
           CareersPage careersPage = new CareersPage();
           return careersPage.IsSearchResultsDisplayed(firstResult);
       }
    }
}
