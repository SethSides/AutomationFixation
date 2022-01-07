using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutomationFixation.Utilities
{
    public static class KeyboardUtilities
    {
        public static IWebDriver Driver = Browser.Browser.Driver;

        public static void Tab()
        {
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.Tab);
        }

        public static void ArrowUp()
        {
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.ArrowUp);
        }

        public static void CtrlAltDelete()
        {
            Actions action = new Actions(Driver);
            action.KeyDown(Keys.Control).SendKeys("a").Build().Perform();

            action.KeyDown(Keys.Control).SendKeys("c").Build().Perform();

            action.KeyDown(Keys.Control).SendKeys("v").Perform();
        }
    }
}
