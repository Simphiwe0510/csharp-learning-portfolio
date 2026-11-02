# Tutorial 06 — Question 1: Books and inheritance

> Existing .NET 8 portfolio version, moved from the previous repository layout. It is separate from the reviewed .NET Framework archive under `originals/`; source and project files were not changed during this import.

**Original student code:** `Book.cs`, `TextBook.cs`, and `Program.cs`, preserved from 2025 UJ coursework. The minimal SDK-style project file and this README were added for portfolio review.

This exercise demonstrates base/derived classes, default and parameterized constructors, properties, `virtual` and `override` methods and console output.

**Known issues in original code:** The `GradeLevel` auto-property is independent of the `gradeLevel` field initialized by constructors; `display()` prints the grade value with the label “Title” instead of “Grade level.” These are documented rather than silently altered to demonstrate honest learning and opportunities for refactoring. `Console.ReadKey()` requires interactive execution.

Run from this directory using `dotnet run` with the .NET 8 SDK.
