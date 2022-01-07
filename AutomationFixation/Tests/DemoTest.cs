using System.Threading;
using AutomationFixation.PageObjects;
using AutomationFixation.Utilities;
using NUnit.Framework;

namespace AutomationFixation.Tests
{
    [TestFixture]
    public class DemoTest : BaseTest
    {
        [Test]
        public void Test1()
        {
            //KeyboardUtilities.CtrlAltDelete();
            //TestPageObject.GetLoginCredentials();
            //TestPageObject.Login("standard_user", "secret_sauce");
           // Browser.Browser.TakeScreenShot("test");

           TestPageObject.UserNameTextBox.Type("Copy and Paste Test");
           //Thread.Sleep(1500);
           TestPageObject.UserNameTextBox.Click();
           //Thread.Sleep(1500);
           KeyboardUtilities.CtrlAltDelete();
           Thread.Sleep(1500);

            TestPageObject.GetStuff();
            
            //var loginButton = Driver.FindElement(By.Id("login-button"));

            //var userNameTextBox = Driver.FindElement(By.Id("user-name"));


            //var passwordTextBox = Driver.FindElement(By.Id("password"));

            //var loginButton = Driver.FindElement(By.Id("login-button"));

            //var acceptedUserNames = Driver.FindElement(By.Id("login_credentials")).Text;

            //var test = Driver.FindElements(By.Id("login_credentials"));


            //var names = test.FindElements(By.XPath("//*[@id=\"login_credentials\"]/text()"));

            //var password = "secret_sauce";

            //userNameTextBox.SendKeys(names[0].Text);

            //passwordTextBox.SendKeys(password);
            
            //loginButton.Click();

            Thread.Sleep(5000);
        }
    }
}
