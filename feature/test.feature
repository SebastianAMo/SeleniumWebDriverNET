Feature: Test Example Site
  
  @Browser_Chrome
  Scenario: Test input on example site
    Given I navigate to "https://example.com"
    Then the title should contain "Example"
