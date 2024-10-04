Feature: Test Login form with empty credentials
  As a user
  I want to test the login form with empty credentials
  So that I can see the appropriate error message

  @smoke
  Scenario Outline: Invalid login with empty credentials in different browsers
    Given I am on the login page with the url "https://www.saucedemo.com/" using "<Browser>"
    When I enter "random_username" and "random_password"
    And I clear the username and password fields
    And I click the login button
    Then I should see the error message "Epic sadface: Username and password do not match any user in this service"

  Examples:
    | Browser   |
    | Chrome    |
    | Firefox   |
