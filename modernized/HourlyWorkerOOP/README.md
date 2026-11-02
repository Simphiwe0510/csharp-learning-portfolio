# Hourly Worker OOP

> Existing .NET 8 portfolio version, moved from the previous repository layout. It is separate from the reviewed .NET Framework archive under `originals/`; source and project files were not changed during this import.

A C# console application created as a learning project to practise object-oriented programming concepts.

## What the Project Does

The program represents an hourly worker and calculates the worker's pay using:

Hours worked × Hourly rate

Example:

- Hours worked: 40
- Hourly rate: 50.00
- Calculated pay: 2000.00

## C# Concepts Demonstrated

- Abstract classes
- Inheritance
- Constructors
- Method overriding
- Encapsulation
- Exception handling
- Input validation
- String interpolation

## Project Structure

- `Worker.cs` - abstract base class for workers
- `HourlyWorker.cs` - inherits from `Worker` and calculates hourly pay
- `Program.cs` - creates and displays an hourly worker
- `AbstractWorker.csproj` - .NET project configuration

## Technologies

- C#
- .NET 8
- Visual Studio Code

## How to Run

Make sure the .NET 8 SDK is installed.

Run:

```bash
dotnet run

```

## Sample Output

```text
Hourly Worker Details
---------------------
Pam Sam | Hours: 40 | Rate: 50.00 | Pay: 2000.00
```

## Purpose

This project forms part of my C# learning portfolio and demonstrates my understanding of core object-oriented programming concepts.