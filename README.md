# Selenium WebDriver POM with C# – Swag Labs Automation
[![C#](https://img.shields.io/badge/Made%20with-C%23-239120.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-5C2D91.svg)](https://dotnet.microsoft.com/)
[![Selenium](https://img.shields.io/badge/tested%20with-Selenium-43B02A.svg)](https://www.selenium.dev/)

### This is a test project for Front-End Test Automation July 2024 Course @ SoftUni

This repository provides a detailed guide to implementing the Page Object Model (POM) pattern in Selenium WebDriver using C#. The goal is to automate key aspects of a web application using POM, focusing on the Swag Labs demo e-commerce platform.

## Application Overview
**Swag Labs** is a demo e-commerce platform built to allow QA engineers to practice automation testing. It features:
- A **Login page** to authenticate users.
- An **Inventory page** that displays available products.
- A **Shopping cart** where users can manage selected products.
- A **Checkout process** to complete purchases.

## Objective
The objective of this project is to demonstrate how to:
- Implement the **Page Object Model (POM)** in a structured and scalable way.
- Automate the complete shopping process from login to checkout using **Selenium WebDriver**.
- Manage complex user interactions.

## Project Structure
- **Pages**: This folder contains the Page Object classes representing various pages of the Swag Labs application.
  - `BasePage.cs`: A base class containing common web driver methods and elements shared across pages.
  - `LoginPage.cs`: Represents the login page and contains methods for logging into the application.
  - `InventoryPage.cs`: Represents the inventory/product page, including methods for selecting products.
  - `CartPage.cs`: Represents the shopping cart and contains methods for managing the cart.
  - `CheckoutPage.cs`: Represents the checkout process, handling form submissions.
  - `HiddenMenuPage.cs`: Handles the hidden menu (if applicable).
  
- **Tests**: This folder contains test classes for different functionalities in the application.
  - `BaseTest.cs`: A base test class that handles setup and teardown of the WebDriver and other shared configurations.
  - `LoginTests.cs`: Tests for validating the login functionality.
  - `InventoryTests.cs`: Tests for product selection on the inventory page.
  - `CartTests.cs`: Tests for managing the shopping cart.
  - `CheckoutTests.cs`: Tests for validating the checkout process.

## Contributing
Contributions are welcome! If you have any improvements or suggestions, feel free to open a pull request.

## License
This project is licensed under the [MIT License](LICENSE). See the [LICENSE](LICENSE) file for details.

## Contact
For any questions or suggestions, please reach out to the course instructor or open an issue in the repository.

---
### Happy Testing! 🚀

