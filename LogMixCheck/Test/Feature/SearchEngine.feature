Feature: Search Engine Check

Scenario: Google Search check
Given I navigated to google search engine
When I search for reqnroll
Then search result is displayed

Scenario: Bing Seach check
Given I navigated to bing search engine
When I search for reqnroll
Then search result is displayed

Scenario: Duck Duck Go search check
Given I navigated to Duck Duck Go search engine
When I search for reqnroll
Then search result is displayed

Scenario: Yahoo Seach Check
Given I navigated to Yahoo search engine
When I search for reqnroll
Then search result is displayed