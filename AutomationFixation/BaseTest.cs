using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AutomationFixation
{
    public class BaseTest
    {
        [SetUp]
        public void SetupTest()
        {
            Browser.Browser.StartTest();
            var url = ConfigurationManager.AppSettings["URL"];
            Browser.Browser.NavigateToUrl(url);
            Browser.Browser.MaximizeWindow();
        }

        [TearDown]
        public void TeardownTest()
        {
            Browser.Browser.EndTest();
        }
    }
}
