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
        [Given(@"I navigate to website '(.*)'")]
        public void NavigateBrowser(string browser)
        {

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
