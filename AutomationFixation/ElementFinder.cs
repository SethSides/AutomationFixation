using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFixation
{
    public static class ElementFinder
    {
        public static IWebDriver Driver = Browser.Driver;

        //public static Browser.ElementFinder Instance = new Browser.ElementFinder();

        public static AutomationFixationElement FindThisDangId(string id)
        {
            return new AutomationFixationElement(Driver.FindElement(By.Id(id)));
        }
    }
}
