using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationFixation
{
    [TestFixture]
    public class DemoTest : BaseTest
    {
        [Test]
        public void Test1()
        {

            TestPageObject.Login("standard_user", "secret_sauce");
            Browser.TakeScreenShot("test");

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
