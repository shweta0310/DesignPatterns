# Design Patterns in C#

This repository contains implementations of various Design Patterns in C#. Each design pattern is implemented as a separate module, demonstrating its usage and providing a practical example. The solution is built using .NET 8 and is designed to help developers understand and practice design patterns in a structured way.

## Table of Contents
1. [Overview](#overview)
2. [Design Patterns Implemented](#design-patterns-implemented)
3. [How to Run](#how-to-run)
4. [Design Pattern Descriptions](#design-pattern-descriptions)
5. [Contributing](#contributing)
6. [License](#license)

## Overview
Design patterns are reusable solutions to common problems in software design. This repository provides examples of Creational, Structural, and Behavioral design patterns. Each pattern is implemented in its own namespace and includes a RunPattern method to demonstrate its functionality.

## Design Patterns Implemented
The following design patterns are included in this solution:
1. Strategy Pattern
2. Observer Pattern
3. Decorator Pattern
4. Factory Method Pattern
5. Abstract Factory Pattern
6. Singleton Pattern
7. Command Pattern
8. Adapter Pattern
9. Facade Pattern
10. Template Method Pattern
11. Iterator Pattern
12. Composite Pattern
13. State Pattern

## How to Run
1. Clone the repository
   ```bash
   git clone https://github.com/your-repo/design-patterns-csharp.git
   cd design-patterns-csharp
   ```
2. Open the solution in Visual Studio 2022.
3. Build the solution to ensure all dependencies are resolved.
4. Run the application. You will be prompted to select a design pattern to execute.
5. Enter the number corresponding to the design pattern you want to run, and the program will demonstrate its functionality.

## Design Pattern Descriptions

### 1. Strategy Pattern
- Demonstrates how to define a family of algorithms, encapsulate each one, and make them interchangeable.
- Example: Solving quadratic equations using different discriminant strategies.

### 2. Observer Pattern
- Implements a subscription mechanism to notify multiple objects about changes in a subject.
- Example: A publisher-subscriber model.

### 3. Decorator Pattern
- Dynamically adds behavior to an object without modifying its structure.
- Example: Adding features to a base object at runtime.

### 4. Factory Method Pattern
- Defines an interface for creating objects but lets subclasses alter the type of objects that will be created.
- Example: Creating different types of products.

### 5. Abstract Factory Pattern
- Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
- Example: Pizza ingredient factories for different cities.

### 6. Singleton Pattern
- Ensures a class has only one instance and provides a global point of access to it.
- Example: A configuration manager.

### 7. Command Pattern
- Encapsulates a request as an object, allowing parameterization of clients with different requests.
- Example: Implementing undo/redo functionality.

### 8. Adapter Pattern
- Converts the interface of a class into another interface clients expect.
- Example: Adapting legacy code to work with a new system.

### 9. Facade Pattern
- Provides a simplified interface to a larger body of code.
- Example: Simplifying access to a complex subsystem.

### 10. Template Method Pattern
- Defines the skeleton of an algorithm in a method, deferring some steps to subclasses.
- Example: Implementing a workflow with customizable steps.

### 11. Iterator Pattern
- Provides a way to access elements of a collection sequentially without exposing its underlying representation.
- Example: Iterating over a custom collection.

### 12. Composite Pattern
- Composes objects into tree structures to represent part-whole hierarchies.
- Example: A file system with directories and files.

### 13. State Pattern
- Allows an object to alter its behavior when its internal state changes.
- Example: A finite state machine.

## Contributing
Contributions are welcome! If you have additional design patterns or improvements to existing implementations, feel free to submit a pull request.

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Commit your changes and push them to your fork.
4. Submit a pull request with a detailed description of your changes.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

---

Happy coding! 🎉
