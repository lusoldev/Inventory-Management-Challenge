# Inventory Management Challenge

## Objectives

Welcome to the **Inventory Management Challenge**!

The purpose of this challenge is to give you an opportunity to demonstrate your technical skills and knowledge. You have **48 hours** to complete this challenge.

## GIT Usage

To complete this task, create a repository (public or private) in your GitHub account. Ensure that all your code is up to date and working properly in the `main` branch.

## Project Details

### Solution Requirements

The solution should be developed using **Visual Studio**, but you may also use **Visual Studio Code** if you prefer. The project consists of two main parts:

- **InventoryManagement**: A Class Library that contains the core business logic.
- **InventoryManagementTests**: A test project to verify that the business logic works correctly.

### Programming Language

The primary language for this challenge is **C#**. However, you may use another programming language you are more comfortable with, as long as the names, method signatures, and specified data structures are respected.

### Best Coding Practices

We value good coding practices, such as clean modularization, descriptive naming conventions, addressing warnings, and following best practices.

### Continuous Integration

A continuous integration pipeline is provided. Each time you push to the `main` branch, the pipeline will execute automatically. Make sure that the code compiles successfully and all tests pass before pushing.

## Validations to Implement

The system requires the implementation of the following validations. The `InventoryProcessor` class contains a `Validate` method where these checks should be implemented. For reference, the first validation is already implemented:

1. **Sequential Product IDs**: Ensure that product IDs start at 1, are sequential, and have no gaps.
2. **Chronological Entries**: Ensure that product entries are added in chronological order. For example, if product entry 1 has a date of January 5th, product entry 2 cannot have an earlier date.
3. **Consistent Product Data**: Each product must consistently have the same ID, name, and price throughout the system.
4. **Non-negative Stock Levels**: The stock level for any product must never be negative.
5. **Correct Entry Value Calculation**: Each product entry's value must be correctly calculated (price \* quantity).
6. **Accurate Inventory Value**: The overall inventory value must be correctly calculated (sum of all product values).
7. **Positive Pricing**: Product prices must always be positive values.
8. **Positive Quantity**: Product quantities must always be positive.
9. **Accurate Total Quantity**: The total number of products in inventory must equal the sum of all product entry quantities.

## Queries to Implement

The system must be able to answer the following queries. There is a corresponding method in the `InventoryProcessor` class for each query. Currently, only **Total Inventory Value** is implemented as an example:

1. **Total Inventory Value**: Calculates the total value of all products.
2. **Product with Highest Stock Quantity**: Returns the ID of the product with the highest stock quantity.
3. **Product with Highest Total Value**: Returns the ID of the product with the highest total value in stock.
4. **Most Frequently Restocked Product**: Returns the name of the product that has been restocked the most.
5. **Inventory Value on Specific Date**: Calculates the total inventory value on a given date.
6. **Top Supplier for a Product**: Returns the ID of the supplier that provided the most units of a particular product.

## Unit Testing

The `InventoryProcessorTest` class contains some example unit tests to verify the provided methods are functioning as expected.

**Examples of tests already implemented:**

- The `Validate` method does not throw any exceptions for a list of valid products.
- The `Validate` method throws an `InvalidProductIDException` with the message "Invalid product ID" for a list with incorrect product IDs.
- The `TotalInventoryValue` method returns the correct value for a list of products.
- The `Validate` method does not throw an exception for an empty list of product entries.
- The `Validate` method does not throw an exception for a single product entry.
- The `Validate` method does not throw an exception for multiple product entries with valid data.
- The `Validate` method throws an `InvalidProductIDException` when product IDs are non-sequential or start from zero.

## Your Task

We would like you to complete the unit tests for the remaining methods and the unfinished validation checks to ensure all functionalities are implemented properly. Examples include:

### Validations

The following validations are defined in `InventoryProcessor` but are not yet implemented. Create unit tests for each of them once implemented:

- **Chronological Entries**: Does the system throw the correct exception when product entries are not in chronological order?
- **Consistent Product Data**: Does the system validate correctly that a product always has consistent data (ID, name, price)?
- **Non-negative Stock Levels**: Is there an exception when the stock level becomes negative?
- **Correct Entry Value Calculation**: Is the total value correctly calculated for each product entry?
- **Accurate Inventory Value**: Is the overall inventory value calculated correctly?
- **Positive Pricing**: Does the system validate that product prices are positive?
- **Positive Quantity**: Does the system validate that product quantities are positive?
- **Accurate Total Quantity**: Is the total number of products in inventory correctly calculated?

### Queries

Write unit tests for the queries that are not yet covered, ensuring they return the expected results. Examples include:

- **Product with Highest Stock Quantity**: Is the product with the highest stock quantity correctly identified?
- **Product with Highest Total Value**: Is the product with the highest total value in stock correctly identified?
- **Most Frequently Restocked Product**: Is the product that has been restocked the most correctly identified?
- **Inventory Value on Specific Date**: Is the total inventory value on a given date accurately calculated?
- **Top Supplier for a Product**: Does the system return the correct supplier for a specific product?

A comprehensive set of tests will help validate that the system logic is implemented correctly and will help catch errors before they occur in production.

**Are you ready to complete the unit tests?**
