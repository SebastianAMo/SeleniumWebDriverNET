Feature: Login
  As a user
  I want to login
  So that I can access the site

  Scenario Outline: Valid login with different browsers
    Given I am on the login page with the url "https://www.saucedemo.com/" using "<Browser>"
    When I enter "standard_user" and "secret_sauce"
    And I click the login button
    Then I should see the title "Swag Labs"

  Examples:
    | Browser   |
    | Edge      |
    | Firefox   |
    | Chrome    |

  Scenario: Invalid login with empty credentials
  	Given I am on the login page with the url "https://www.saucedemo.com/" using "Chrome"
    When I enter "random_username" and "random_password"
    And I clear the username and password fields
    And I click the login button
	Then I should see the error message "Epic sadface: Username and password do not match any user in this service"

  Scenario: Invalid login with credentials by passing Username
   Given I am on the login page with the url "https://www.saucedemo.com/" using "Chrome"
	When I enter "standard_user" and "random_password"
    And I clear the password field
    And I click the login button
    Then I should see the error message "Epic sadface: Username and password do not match any user in this service"