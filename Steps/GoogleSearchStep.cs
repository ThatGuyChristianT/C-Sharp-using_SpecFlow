using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GoogleTest.Steps
{
    [Binding]
    class GoogleSearchStep
    {
        IWebDriver driver = null;
        [Given(@"I navigate to website '(.*)'")]
        public void NavigateBrowser(string browser)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(browser);
            System.Threading.Thread.Sleep(5000);

        }

        [Then(@"I see Google page is loaded")]
        public Boolean IsGooglePageLoaded()
        {
            return false;
        }
        //Given I navigate to website "https://www.google.com"
        //Then I see Google page is loaded
        //   When I enter "" on searchbox

        //   And click on Search
    }
}
