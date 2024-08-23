# Banking System Application

A C# Windows Forms application for managing user accounts, handling deposits, withdrawals, and displaying transaction histories. This project was developed with a focus on inheritance, encapsulation, and abstract class design to implement a simplified banking system.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Key Design Patterns](#key-desing-patterns)
- [License](#license)

## Introduction

This project demonstrates a basic banking application with functionality for different account types such as Everyday, Omni, and Invest accounts. The application leverages object-oriented principles in C# to provide a modular and extendable codebase.

**Note:** If you're developing or running this project on a Mac, you will need to use a Windows virtual machine. The project was tested on VMware Fusion running Windows 11.

## Features

- **User Management**: Creation of user accounts.
- **Account Types**: Support for Everyday, Omni, and Invest accounts with unique behaviors.
- **Transaction Handling**: Deposit, withdraw, and transaction history management.
- **Custom UI Components**: Implementation of custom panels and buttons with border radius and border width.
- **Validation**: Includes basic validation for deposits and withdrawals.

- 

![C# Bank Design App](https://github.com/user-attachments/assets/e6b475b7-08aa-4ad6-84fc-8fcd9627e721)


## Installation

### Prerequisites

- **Windows OS** (Required for running Windows Forms applications)
- **VMware Fusion** (For Mac users running Windows 11 in a virtual machine)
- **Visual Studio** (For development and compilation)

### Steps

1. **Clone the repository:**

   ```
   git clone https://github.com/your-username/your-repo-name.git
   '''

2. **Open the project in Visual Studio:**
- Open Visual Studio.
- Go to `File > Open > Project/Solution`.
- Select the `.sln `file from the cloned repository.

3. ** Build and run the application:**
-  You can run the app by pressing the `F5 `key or by selecting `Debug > Start Debugging` from the menu.

## Usage

- **Main Page Overview**: Provides a glance at all accounts, displaying account names and balances. Users can view detailed information by clicking on an account. The page also shows basic user information and a summary of recent transactions.
- **Transactions**: Use specific buttons to perform deposits and withdrawals. Transactions can be initiated from the main page or detailed account views.
- **Transaction History**: View recent transactions in both the Home view and detailed account views.


## Project Structure

- **Model**: Contains business logic classes (`User`, `Account`, `Everyday`, `Omni`, `Invest`).
- **Controllers**: Manages interactions between the UI and the business logic.
- **Components**: Contains custom panels, buttons. Lots of UI elements are defined in the designer Files.


## Key Design Patterns

- **Abstract Classes**: Used for defining base behaviors in the `Account` class, with specific behaviors overridden in derived classes.
- **Observer Pattern**: Applied for UI updates, ensuring that changes in the model are reflected in the views.
- **Custom UI Elements**: Custom panels and buttons were created to achieve specific visual designs, such as rounded corners and custom borders. This was necessary because standard UI controls did not meet the design requirements. Custom drawing and manual adjustments were required to achieve the desired look and feel, demonstrating the application of creative problem-solving in UI design.
  
## License

This project is licensed under the MIT License. 







