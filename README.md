# Game Library & Player Stats Manager

## Overview
This project is a console-based **Game Library and Player Statistics Manager** developed in C#. 
The system allows users to manage player records, track gameplay statistics, and keep data between sessions using file storage.

The application was developed based on **Scenario 1: Game Library & Player Stats Manager**, provided in the brief.

---

## Features
- Add new players with IDs and usernames
- Record and update gameplay statistics
- Search for players by ID or username
- Sort players by hours played or high score
- Persist data using JSON file storage
- Log important system actions to a text file
- Error handling for invalid input and file I/O
- Unit testing using a test project

---

## Technologies Used
- C# (.NET Console Application)
- Object-Oriented Programming (OOP)
- JSON data persistence
- GitHub for version control
- MSTest for unit testing

---

## Design Patterns
The following design patterns were applied in this project:

- **Singleton Pattern**  
  Used in the `Logger` class to give a single shared logging instance across the application.

- **Repository Pattern**  
  The `PlayerManager` class encapsulates all player data operations, improving separation of concerns and testability.

---

## How to Run the Application
1. Clone or download the repository from GitHub
2. Open the solution file (`.sln`) in Visual Studio
3. Build the solution to restore dependencies
4. Run the console application
5. Use the menu options to interact with the system

---

## Data Persistence
- Player data is saved to a `players.json` file
- System logs are written to `log.txt`
- Data is automatically loaded when the application starts

---

## Testing
A separate unit test project is included. The tests validate core functionality such as adding players, searching, sorting, and file persistence. All tests can be run using Visual Studio’s Test Explorer.

