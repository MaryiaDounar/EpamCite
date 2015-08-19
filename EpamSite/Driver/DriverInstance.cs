using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace EpamSite.Driver
{
   public class DriverInstance
    {
       private static IWebDriver driver;

       private DriverInstance() { }

       public static IWebDriver GetInstance()
       {
           if(driver == null)
           {
               driver = CreateBrowser();
               driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
               driver.Manage().Window.Maximize();
           }
           return driver;
       }

       public static IWebDriver CreateBrowser()
       {
          IWebDriver driver = new FirefoxDriver();
          return driver;
       }

       public static void CloseBrowser()
       {
           driver.Quit();
           driver = null;
       }
    }
}
