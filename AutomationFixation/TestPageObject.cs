using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V85.DOM;

namespace AutomationFixation
{
    public static class TestPageObject
    {
        //private static readonly IWebElement Element;
        public static IWebDriver Driver;

        //public static IWebElement Element;

        //public TestPageObject(IWebDriver driver, IWebElement element)
        //{
        //    Driver = driver;
        //}


        public static AutomationFixationElement LoginButton => ElementFinder.FindThisDangId("login-button");

        public static AutomationFixationElement UserNameTextBox => ElementFinder.FindThisDangId("user-name");
        public static AutomationFixationElement PasswordTextBox => ElementFinder.FindThisDangId("password");

        public static AutomationFixationElement Testing => ElementFinder.FindThisDangId("login-button");

        public static string GetStuff()
        {
            Browser.GetCurrentUrl();
            Browser.GetPageTitle();
            Browser.GetCurrentPageHtmlSource();
            return "This";
        }

        public static void Move()
        {
            //AutomationFixationElement.DragAndDrop(LoginButton, (IWebElement)UserNameTextBox);
        }
        


        public static void EnterUserName(string userName)
        {
            UserNameTextBox.Type(userName);
        }

        public static void EnterPassword(string password)
        {
            PasswordTextBox.Type(password);
        }

        public static void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public static void Login(string userName, string password)
        {
            EnterUserName(userName);
            EnterPassword(password);
            ClickLoginButton();
        }
    }
}
