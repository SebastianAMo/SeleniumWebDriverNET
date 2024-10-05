# SeleniumWebDriverNET

This project uses SpecFlow, Selenium WebDriver, and LivingDoc to generate documentation from automated tests

## Technologies

- .NET 8
- SpecFlow
- XUnit
- Selenium WebDriver
- LivingDoc
- BBD

## Browser Support

Currently, the project supports the following browsers:

- Chrome
- Firefox
- Edge

In the scenarios, to use different browsers, Scenario Outlines are used, which take the browsers to be used as examples.

## Tasks

1. UC-1 Test Login form with empty credentials

	Type any credentials into "Username" and "Password" fields.
	Clear the inputs.
	Hit the "Login" button.
	Check the error messages: "Username is required".

2. UC-2 Test Login form with credentials by passing Username

	Type any credentials in username.
	Enter password.
	Clear the "Password" input.
	Hit the "Login" button.
	Check the error messages: "Password is required".


3. UC-3 Test Login form with credentials by passing Username & Password

	Type credentials in username which are under Accepted username are sections.
	Enter password as secret sauce.
	Click on Login and validate the title “Swag Labs” in the dashboard.

## Notes

- UC-1 and UC-2 failed when clear fields with the `Clear()` method. The error message with this method is : `Epic sadface: Username and password do not match any user in this service`.

  I used the `SendKeys(Keys.Control + "a")` method to select all the text in the input and then the `SendKeys(Keys.Delete)` method to delete the text. Another approach to clearing the fields is to simulate deleting the text character by character. 

## Commands

The following commands are used to run the project

- Install LivingDoc CLI
  ```bash
  dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
  ```

- Clean the project
  ```bash
  dotnet clean
  ```

- Clean and restore the project
  ```bash
  dotnet restore
  ```

- Build the project
  ```bash
  dotnet build
  ```

- Run the tests and generate a test report
  ```bash
  dotnet test --logger "trx;LogFileName=TestExecution.trx" --results-directory ./bin/Debug/net8.0
  ```

- Generate LivingDoc report
  ```bash
  livingdoc test-assembly ./bin/Debug/net8.0/SeleniumWebDriverNET.dll -t ./bin/Debug/net8.0/TestExecution.json --output ./bin/Debug/net8.0/LivingDocReport.html
  ```


- Open the LivingDoc report
  ```bash
  start ./bin/Debug/net8.0/LivingDocReport.html
  ```

- Run the tests with a filter
  ```bash
  dotnet test --filter FullyQualifiedName~Login.feature
  ```

- Run the tests with a tag
  ```bash
  dotnet test --filter TestCategory=important
  ```

### Author

[Sebastian Agudelo Morales](https://www.linkedin.com/in/sebastianamo) 
