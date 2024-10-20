# Part 1: Banking System Interface For Handling User Transations

A C# Windows Forms application for managing user accounts, handling deposits, withdrawals, and displaying transaction histories. This project was developed with a focus on inheritance, encapsulation, and abstract class design to implement a simplified banking system.

## Table of Contents

- [Part 1: Banking System Interface For Handling User Transactions](#part-1-banking-system-interface-for-handling-transactions)
   - [1.1 Introduction](#11-introduction)
   - [1.2 Features](#12-features)
   - [1.3 Installation](#13-installation)
   - [1.4 Usage](#14-usage)
   - [1.5 Project Structure](#15-project-structure)
   - [1.6 Key Design Patterns](#16-key-design-patterns)
   - [1.7 License](#17-license)
- [Part 2: Banking System Interface CMS for Users](#part-2-banking-system-interface-cMS-for-users)
  - [2.1 Introduction](#21-introduction)
  - [2.2 Features](#22-features)
  - [2.3 Testing](#23-testing)

## 1.1 Introduction

This project demonstrates a basic banking application with functionality for different account types such as Everyday, Omni, and Invest accounts. The application leverages object-oriented principles in C# to provide a modular and extendable codebase.

**Note:** If you're developing or running this project on a Mac, you will need to use a Windows virtual machine. The project was tested on VMware Fusion running Windows 11.

## 1.2 Features

- **User Management**: Creation of user accounts.
- **Account Types**: Support for Everyday, Omni, and Invest accounts with unique behaviors.
- **Transaction Handling**: Deposit, withdraw, and transaction history management.
- **Custom UI Components**: Implementation of custom panels and buttons with border radius and border width.
- **Validation**: Includes basic validation for deposits and withdrawals.

- 

![C# Bank Design App](https://github.com/user-attachments/assets/e6b475b7-08aa-4ad6-84fc-8fcd9627e721)


## 1.3 Installation

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

## 1.4 Usage

- **Main Page Overview**: Provides a glance at all accounts, displaying account names and balances. Users can view detailed information by clicking on an account. The page also shows basic user information and a summary of recent transactions.
- **Transactions**: Use specific buttons to perform deposits and withdrawals. Transactions can be initiated from the main page or detailed account views.
- **Transaction History**: View recent transactions in both the Home view and detailed account views.


## 1.5 Project Structure

- **Model**: Contains business logic classes (`User`, `Account`, `Everyday`, `Omni`, `Invest`).
- **Controllers**: Manages interactions between the UI and the business logic.
- **Components**: Contains custom panels, buttons. Lots of UI elements are defined in the designer Files.


## 1.6 Key Design Patterns

- **Abstract Classes**: Used for defining base behaviors in the `Account` class, with specific behaviors overridden in derived classes.
- **Observer Pattern**: Applied for UI updates, ensuring that changes in the model are reflected in the views.
- **Custom UI Elements**: Custom panels and buttons were created to achieve specific visual designs, such as rounded corners and custom borders. This was necessary because standard UI controls did not meet the design requirements. Custom drawing and manual adjustments were required to achieve the desired look and feel, demonstrating the application of creative problem-solving in UI design.
  
## 1.7 License

This project is licensed under the MIT License. 

# Part 2: Banking System Interface CMS for Users 

[Back to Top](#table-of-contents)

## 2.1 Introduction

Development of a prototype for the management of the banking customer information. Using MVC Pattern, this User Form is designed for adding, updating and deleting customer informations. It integrates the Form with a Controller Class (UserAdmin.cs) to manage interactions.

At this stage of the development, there is no Login Form to switch from the Banking application and the CMS for Customers (Part 3 of this project)

## 2.2 Features

- **MVC Pattern**: In the Model-View-Controller (MVC) pattern, the controller serves as the intermediary between the UI and the data model. The goal is to centralize data management within the controller, ensuring that the business logic is kept separate from the user interface and that data flows between the UI and models in a controlled way.
In my design, the UserAdmin controller manages a centralized list of users, performs CRUD operations, and handles account management.
- **Friendly UI**: Creation of  a user interface that incorporates the company’s branding elements and interact with the Controller Class.
- **Exception Classes**: Creation of an exception class that inherits from a base exception class. Implementing custom exceptions reflecting different types of accounts (e.g., Everyday, Omni and Invest) with meaningful messages.

## 2.3 testing

### Testing Results:

![Testing results](https://github.com/redblindbananaz/BankManagementSystem/blob/master/Images/TestResults.png)













