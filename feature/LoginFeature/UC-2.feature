Feature: Test Login form with only username
  As a user
  I want to test the login form by passing only username
  So that I can see the appropriate error message

  Scenario Outline: Invalid login with credentials by passing Username in different browsers
    Given I am on the login page with the url "https://www.saucedemo.com/" using "<Browser>"
    When I enter "standard_user" and "random_password"
    And I clear the password field
    And I click the login button
    Then I should see the error message "Epic sadface: Password is required"

  Examples:
    | Browser   |
    | Chrome    |
    | Firefox   |
