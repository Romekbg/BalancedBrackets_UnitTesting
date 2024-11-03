# BalancedBrackets_UnitTesting
BalancedBrackets_UnitTesting

# BalancedBrackets_UnitTesting

## Description
The `BalancedBrackets_UnitTesting` project is designed to determine if a series of brackets are balanced. The main functionality is implemented in the `BalancedBrackets` class, which provides a method to check for balance in an array of string inputs representing brackets. The project includes unit tests written with NUnit to validate the correctness of the `IsBalanced` method.

## Table of Contents
- [Installation](#installation)
- [Usage](#usage)
- [Testing](#testing)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgments](#acknowledgments)
- [Contact](#contact)

## Installation
To set up the project locally, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/Romekbg/BalancedBrackets_UnitTesting.git

2. Navigate to the project directory:
   cd BalancedBrackets_UnitTesting

3. Open the solution file in Visual Studio or your preferred C# IDE.

4. Ensure that you have the necessary dependencies. This project uses NUnit for testing, so make sure it's included in your project.

Usage
To check if a series of brackets are balanced, use the IsBalanced method from the BalancedBrackets class. Here’s how you can use it:
using TestApp;

string[] brackets = new string[] { "(", ")" };
bool isBalanced = BalancedBrackets.IsBalanced(brackets);
Console.WriteLine(isBalanced); // Output: True

using TestApp;

string[] brackets = new string[] { "(", ")" };
bool isBalanced = BalancedBrackets.IsBalanced(brackets);
Console.WriteLine(isBalanced); // Output: True

Testing
This project includes unit tests that can be run using NUnit. To execute the tests:

Open the Test Explorer in Visual Studio.
Build the solution.
Run all tests to validate the functionality of the IsBalanced method.
Test Cases
Here are some of the key test cases included:

Empty Input: Should return True
Double Balanced Brackets: Input ("(", ")", "(", ")") should return True
No Brackets: Input ("No Brackets added") should return True
Unbalanced Brackets: Input (")", "(") should return False
More Closing Brackets: Input ("(", ")", "(", ")", ")") should return False
Special Characters: Input ("[", ",", "]") should return True
No Closing Brackets: Input (")", "(", ")") should return False
Contributing

Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

Fork the repository.
Create your feature branch:

git checkout -b feature/NewFeature
Commit your changes:

git commit -m "Add some feature"

Push to the branch:

git push origin feature/NewFeature
Open a pull request.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

