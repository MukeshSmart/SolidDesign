**﻿Single Responsibility Principle (SRP):**

Break down the system into classes that have a single responsibility. For instance, have separate classes for handling pregnancy-related information, medical checkups, and delivery.

**Open/Closed Principle (OCP):**

Design classes in a way that allows for extension without modification. For example, create interfaces and abstract classes that can be extended by concrete implementations for different stages of pregnancy.

**Liskov Substitution Principle (LSP):**

Ensure that objects of the base class (e.g., PregnancyStage) can be replaced by objects of derived classes (e.g., Trimester) without affecting the correctness of the program.

**Interface Segregation Principle (ISP):**

Split large interfaces into smaller and more specific ones. For instance, separate interfaces for tracking pregnancy progress, handling medical checkups, and managing the delivery process.

**Dependency Inversion Principle (DIP):**

Depend on abstractions, not on concrete implementations. Use interfaces and abstract classes to allow for flexibility and easier maintenance.
