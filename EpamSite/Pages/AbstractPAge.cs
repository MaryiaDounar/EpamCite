using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace EpamSite.Pages
{
   public abstract class AbstractPage
    {
       public abstract void OpenPage();

       public bool IsElementDisplayed(IWebElement element)
       {
           return element.Displayed;
       }
    }
}
