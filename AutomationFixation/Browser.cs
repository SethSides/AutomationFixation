using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace AutomationFixation
{
    public static class Browser
    {
        public static string BrowserType = ConfigurationManager.AppSettings["BrowserType"];
        public static IWebDriver Driver;

        public static IWebDriver StartTest()
        {
            return Driver = BrowserConfiguration.CreateDriver(BrowserType);
        }

        public static void EndTest()
        {
            Driver.Dispose();
        }

        public static void MaximizeWindow()
        {
            Driver.Manage().Window.Maximize();
        }

        public static void NavigateToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public static void NavigateBack()
        {
            Driver.Navigate().Back();
        }

        public static void NavigateForward()
        {
            Driver.Navigate().Forward();
        }

        public static void RefreshPage()
        {
            Driver.Navigate().Refresh();
        }

        public static string GetPageTitle()
        {
            return Driver.Title;
        }

        public static string GetCurrentUrl()
        {
            return Driver.Url;
        }

        public static string GetCurrentPageHtmlSource()
        {
            return Driver.PageSource;
        }

        public static void TakeScreenShot(string screenShotFileName)
        {
            Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();

            //TODO: Make filepath dynamic using current directory, and give the option for saving multiple file types

            var filePath = "C:\\Users\\ssides\\Documents\\Screenshots\\";
            var fileName = screenShotFileName;
            var fileType = ".jpg";
            var fullName = filePath + fileName + fileType;
            
            ss.SaveAsFile(fullName, ScreenshotImageFormat.Jpeg);
        }

        public static void Something(AutomationFixationElement elementTo, AutomationFixationElement elementFrom)
        {
            Actions action = new Actions(Driver);
            action.DragAndDrop((IWebElement)elementFrom, (IWebElement)elementTo);
        }
    }
}
