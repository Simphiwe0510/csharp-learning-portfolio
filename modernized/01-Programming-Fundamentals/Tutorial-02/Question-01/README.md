# Tutorial 02 — Question 1: Linear search in an array

> Existing .NET 8 portfolio version, moved from the previous repository layout. It is separate from the reviewed .NET Framework archive under `originals/`; source and project files were not changed during this import.

**Student-authored original:** `Program.cs`, from my 2025 UJ C# coursework. The minimal SDK-style `Question01.csproj` and documentation were added later to support review.

This console exercise generates ten random integers, prints them, asks for a search value and searches sequentially for the first matching index. It uses an integer array, `for` loops, a sentinel value (`-1`) and a `break`.

**Known limitations:** `int.Parse` can throw on invalid input; `Console.ReadKey()` requires an interactive terminal. The code has been preserved as written rather than presented as production-ready.

Run from the project directory with `dotnet run` using .NET 8.
