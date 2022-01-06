using OpenQA.Selenium;

namespace AutomationFixation.PageObjects
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


        public static AutomationFixationElement LoginButton => ElementFinder.FindById("login-button");

        public static AutomationFixationElement UserNameTextBox => ElementFinder.FindById("user-name");
        public static AutomationFixationElement PasswordTextBox => ElementFinder.FindById("password");

        public static AutomationFixationElement Testing => ElementFinder.FindById("login-button");

        public static AutomationFixationElement LoginCredentials => ElementFinder.FindById("login_credentials");

        //public static string GetStuff()
        //{
        //    Browser.GetCurrentUrl();
        //    Browser.GetPageTitle();
        //    Browser.GetCurrentPageHtmlSource();
        //    return "This";
        //}

        public static void GetStuff()
        {
            UserNameTextBox.Type("test");
            PasswordTextBox.Type("test");
            LoginButton.Click();
        }

        public static void Move()
        {
            //AutomationFixationElement.DragAndDrop(LoginButton, (IWebElement)UserNameTextBox);
        }

        public static void GetLoginCredentials()
        {
            LoginCredentials.GetText();
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1));
            //wait.Until(LoginCredentials.IsDisplayed());
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
