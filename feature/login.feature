Feature: Login
  As a user
  I want to login
  So that I can access the site

  Scenario Outline: Valid login with different browsers
    Given I am on the login page with the url "https://www.saucedemo.com/" using "<Browser>"
    When I enter "<Username>" and "<Password>"
    And I click the login button
    Then I should be redirected to the home page

  Examples:
    | Browser   | Username      | Password     |
    | Edge      | standard_user | secret_sauce |
    | Firefox   | standard_user | secret_sauce |
    | Chrome    | standard_user | secret_sauce |
