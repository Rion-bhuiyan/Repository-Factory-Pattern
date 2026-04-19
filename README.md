🚀 Repository & Factory Pattern in C#:

A professional-grade demonstration of the Repository Pattern combined with the Factory Pattern in C#. This project showcases how to implement a decoupled architecture for managing client records in a clean, maintainable, and scalable way.

📋 Table of Contents
Overview

Design Patterns Used

Project Structure

Features

Getting Started

Usage Examples

Code Architecture

Author

🎯 Overview
This application serves as a comprehensive guide for implementing enterprise-level design patterns in a .NET environment. By abstracting data access logic, the system ensures that the business logic remains completely independent of the data storage layer.

🏗️ Design Patterns Used
1. Repository Pattern
Acts as an abstraction layer between the business logic and the data source.

Benefit: Decouples the application from the underlying data technology (SQL, In-memory, etc.).

Consistency: Provides a uniform API for all data operations.

2. Factory Pattern
Responsible for instantiating the correct repository instances.

Benefit: Centralizes object creation logic, making dependency management much easier.

Scalability: Allows adding new entities without modifying the existing client-side code.

📁 Project Structure
Plaintext
Repository_Factory_Pattern/
│
├── Models/
│   └── Client.cs              # Client Entity (POCO) with ID, Name, and Age
│
├── Repositories/
│   ├── IRepository.cs         # Generic interface defining the CRUD contract
│   └── ClientRepo.cs          # Concrete implementation for Client-specific logic
│
├── Factories/
│   └── RepositoryFactory.cs   # The Engine that instantiates the Repositories
│
├── Program.cs                 # Main Entry Point & Interactive Console UI
└── App.config                 # Application configuration file
✨ Features
Full CRUD Operations: Support for Viewing, Inserting, Updating, and Deleting client records.

Auto-ID Management: Intelligent logic to handle unique identifiers for every client record.

Design Pattern Driven: Strictly adheres to Repository and Factory design principles.

Clean Console UI: An interactive, menu-driven interface for a seamless user experience.

Scalable Architecture: Built with a "Code-First" mindset, ready for future database integration (SQL Server/Dapper).

🚀 Getting Started
Prerequisites
.NET Framework 4.8 or higher.

Visual Studio 2019/2022 (Recommended).

Installation
Clone the Repository:

Bash
git clone https://github.com/Rion-bhuiyan/-Repository-Factory-Pattern.git
Open Solution: Launch the .sln file in Visual Studio.

Build: Press Ctrl+Shift+B to build the solution.

Run: Press F5 to start the interactive console.

💡 Usage Examples
Initializing the Repository
C#
// Get the repository instance through the Factory
var clientRepo = RepositoryFactory.GetRepository<ClientRepo>();
CRUD Operations
C#
// CREATE: Adding a new client
var newClient = new Client { ClientId = 1, ClientName = "Al Arafat", Age = 24 };
clientRepo.Insert(newClient);

// READ: Getting all records
var allClients = clientRepo.GetAll();

// UPDATE: Modifying an existing record
newClient.ClientName = "Al Arafat Bhuiyan";
clientRepo.Update(newClient);

// DELETE: Removing a record
clientRepo.Delete(1);
🏛️ Code Architecture
Client Model
C#
public class Client {
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public int Age { get; set; }
}
Generic Interface
C#
public interface IRepository<T> {
    IEnumerable<T> GetAll();
    void Insert(T entity);
    void Update(T entity);
    void Delete(int id);
}
🎓 Learning Outcomes
By studying this project, you will learn:

Implementing the Repository Pattern to hide data storage details.

Using the Factory Pattern to centralize object instantiation.

Managing In-Memory collections like real-world databases.

Following SOLID principles in a C# environment.

👤 Author
Al Arafat Bhuiyan

GitHub: [@Rion-bhuiyan](https://github.com/Rion-bhuiyan)

Role: Full-Stack Developer Trainee (ISDB-BISEW)
