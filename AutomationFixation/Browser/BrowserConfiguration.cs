using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace AutomationFixation.Browser
{
    public static class BrowserConfiguration
    {
        public static int DefaultTimeout = int.Parse(ConfigurationManager.AppSettings["DefaultTimeout"]);

        public static WebDriver CreateDriver(string browserType)
        {
            switch (browserType)
            {
                case "Chrome":
                    return ChromeDriver();
                case "FireFox":
                    return FireFoxDriver();
                case "IE":
                    return IeDriver();
                default:
                    string message = "The argument that was received is not recognized as a valid Browser Type";
                    string paramName = "browserType";
                    throw new ArgumentException(message, paramName);
            }
        }

        private static WebDriver ChromeDriver()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(DefaultTimeout);
            return chromeDriver;
        }

        private static FirefoxDriver FireFoxDriver()
        {
            var fireFoxDriver = new FirefoxDriver();
            return fireFoxDriver;
        }

        private static InternetExplorerDriver IeDriver()
        {
            var internetExplorerDriver = new InternetExplorerDriver();
            return internetExplorerDriver;
        }
    }
}
