# Description

This code implements a basic calculator application with unit tests. The application supports addition, subtraction, multiplication, division, and logging of operations. It also includes a menu-driven interface for user interaction.

## Technologies Used

1. **C#**: The primary programming language used for the application and tests.
2. **xUnit**: A testing framework for .NET used to create and run unit tests.


## Project Structure

This project is organized into two distinct solutions, each serving a specific purpose to ensure a clear separation of concerns, enhancing maintainability and readability.

### Calculator Solution

The calculator solution contains the core implementation of the application. It includes:
- **Basic Arithmetic Operations**: Functions for addition, subtraction, multiplication, and division.
- **Logging Mechanism**: A system to log the history of operations performed by the user.
- **User Interface**: A menu-driven interface for user interaction, allowing users to select operations and view logs.

### Testing Solution

The testing solution is dedicated to verifying the functionality and reliability of the calculator application. It leverages:
- **xUnit**: A testing framework for .NET to create and run unit tests.

### Key Features

- **Unit Tests**: Comprehensive tests for each arithmetic operation and user interaction.
- **Test Scenarios**: Various scenarios to ensure the calculator operates as expected, including edge cases like division by zero.
- **User Interaction Tests**: Tests to simulate user input and verify the correct output and logging behavior.

By separating the application logic and testing functionalities into two solutions, the project maintains a high level of code quality and reliability.

## Test Description

### CalculatorXUnit

1. **CalculatorFunctionsTest Class**: Tests for basic arithmetic operations.
    - **Add_50_And_50_Return_100()**: Verifies that adding 50 and 50 returns 100.
    - **Multiply_Test()**: Tests the multiplication function with various inputs.
    - **Division_Test()**: Tests the division function, including a case for division by zero.
    - **Subtraction_Test()**: Tests the subtraction function with various inputs.

2. **UserInputOutputTest Class**: Tests for user input/output functionalities.
    - **Input_ShouldReturnValidNumber()**: Verifies that the input function returns the correct integer from a string input.
    - **User_ShouldBeAbleToPerformSubtractionAndViewLogs()**: Simulates user input to perform subtraction and view logs.
    - **User_ShouldBeAbleToExit()**: Simulates user input to exit the application.
    - **User_ShouldBeAbleToViewLogs()**: Simulates user input to perform addition and view logs.

# Test Case: User_ShouldBeAbleToPerformSubtractionAndViewLogs

### Instructions and Expected Result:

1. **Start the application**
2. **Select menu option "Subtraction"**
   - Enter `2`, and press `enter`
   - Expected result: Subtraction option is selected
3. **Enter the number 30**
   - Press `enter`
   - Expected result: First number entered
4. **Enter the number 15**
   - Press `enter`
   - Expected result: Second number entered
5. **Expected result**: 
   - Output: `30 - 15 = 15`
6. **Select menu option "History"**
   - Enter `5`, and press `enter`
   - Expected result: 
     ```
     30 - 15 = 15
     -----------------
     ```
7. **Select menu option "Exit"**
   - Enter `7`, and press `enter`
   - Expected result: Program should turn off

---

# Test Case: User_ShouldBeAbleToExit

### Instructions and Expected Result:

1. **Start the application**
2. **Select menu option "Exit"**
   - Enter `7`, and press `enter`
   - Expected result: Program should turn off

---

# Test Case: User_ShouldBeAbleToViewLogs

### Instructions and Expected Result:

1. **Start the application**
2. **Select menu option "Addition"**
   - Enter `1`, and press `enter`
   - Expected result: Addition option is selected
3. **Enter the number 10**
   - Press `enter`
   - Expected result: First number entered
4. **Enter the number 20**
   - Press `enter`
   - Expected result: Second number entered
5. **Expected result**: 
   - Output: `10 + 20 = 30`
6. **Select menu option "History"**
   - Enter `5`, and press `enter`
   - Expected result: 
     ```
     10 + 20 = 30
     ----------------------
     ```
7. **Select menu option "Exit"**
   - Enter `7`, and press `enter`
   - Expected result: Program should turn off
