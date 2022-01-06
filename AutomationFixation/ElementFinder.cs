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

        public static AutomationFixationElement FindById(string id)
        {
            return new AutomationFixationElement(Driver.FindElement(By.Id(id)));
        }

        public static AutomationFixationElement FindByClassName(string className)
        {
            return  new AutomationFixationElement(Driver.FindElement(By.ClassName(className)));
        }

        public static AutomationFixationElement FindByCssSelector(string cssSelector)
        {
            return new AutomationFixationElement(Driver.FindElement(By.CssSelector(cssSelector)));
        }

        public static AutomationFixationElement FindByLinkText(string linkText)
        {
            return new AutomationFixationElement(Driver.FindElement(By.LinkText(linkText)));
        }

        public static AutomationFixationElement FindByName(string name)
        {
            return new AutomationFixationElement(Driver.FindElement(By.Name(name)));
        }
        public static AutomationFixationElement FindByPartialLinkText(string partialLinkText)
        {
            return new AutomationFixationElement(Driver.FindElement(By.PartialLinkText(partialLinkText)));
        }

        public static AutomationFixationElement FindByClassTagName(string tagName)
        {
            return new AutomationFixationElement(Driver.FindElement(By.TagName(tagName)));
        }

        public static AutomationFixationElement FindByXpath(string xpath)
        {
            return new AutomationFixationElement(Driver.FindElement(By.XPath(xpath)));
        }
    }
}
