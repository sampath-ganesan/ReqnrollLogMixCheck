using LogMixCheck.Utilities;
using Reqnroll;

namespace LogMixCheck.Test.Steps
{
    [Binding]
    public class SearchEngineStep
    {
        private readonly ScenarioContext scenarioContext;

        public SearchEngineStep(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given("I navigated to (.*) search engine")]
        public void GivenINavigatedToSearchEngine(string searchEngine)
        {
            switch (searchEngine.ToLower())
            {
                case "google":
                    Browser.GoToUrl("https://google.com");
                    break;
                case "bing":
                    Browser.GoToUrl("https://bing.com");
                    break;
                case "duck duck go":
                    Browser.GoToUrl("https://duckduckgo.com");
                    break;
                case "yahoo":
                    Browser.GoToUrl("https://yahoo.com");
                    break;
            }
        }

        [When("I search for reqnroll")]
        public void WhenISearchForReqnroll()
        {
        }

        [Then("search result is displayed")]
        public void ThenSearchResultIsDisplayed()
        {
        }
    }
}
