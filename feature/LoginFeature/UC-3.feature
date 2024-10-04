Feature: Test Login form with valid credentials
  As a user
  I want to test the login form with valid credentials
  So that I can successfully login to the site

  Scenario Outline: Valid login with different browsers
    Given I am on the login page with the url "https://www.saucedemo.com/" using "<Browser>"
    When I enter "standard_user" and "secret_sauce"
    And I click the login button
    Then I should see the title "Swag Labs"

  Examples:
    | Browser   |
    | Firefox   |
    | Chrome    |