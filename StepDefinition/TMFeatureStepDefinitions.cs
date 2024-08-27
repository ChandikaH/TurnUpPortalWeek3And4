using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TurnUpPortalWeek3And4.StepDefinition
{
    [Binding]
    public class TMFeatureStepDefinitions
    {
        [Given(@"I logged into Turnup portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            Console.WriteLine("Login - I logged into Turnup portal successfully");
        }

        [When(@"I navigate to Time and Material Page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            Console.WriteLine("TM - I navigate to Time and Material Page");
        }

        [When(@"I create a new Time record")]
        public void WhenICreateATimeRecord()
        {
            Console.WriteLine("Create - I create a new Time record");
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            Console.WriteLine("Verify - the record should be created successfully");
        }
    }
}
