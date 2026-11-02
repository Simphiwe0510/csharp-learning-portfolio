# C# Learning Portfolio | University of Johannesburg

2025 C# coursework covering arrays, inheritance, exceptions, file handling and Windows Forms.

All **22 projects in the reviewed coursework ZIP** are published under [originals](originals/). The four previously published .NET 8 projects are retained under [modernized](modernized/). These represent **23 distinct exercises**, with three archive/modernized pairs and one existing HourlyWorkerOOP exercise.

- [Complete project index](PROJECT_INDEX.md)
- [Build and verification report](VERIFICATION_AND_PUBLICATION_REPORT.md)
- [Source preservation and publication audit](docs/PUBLICATION_AUDIT.md)
- [Learning roadmap](LEARNING_ROADMAP.md)

## Build and run

Original projects target .NET Framework 4.7.2. Use Windows, Visual Studio or Build Tools with MSBuild and the 4.7.2 developer pack. Each exercise has a solution and README. The three Windows Forms applications require Windows for execution.

The existing modernized versions target .NET 8. Run `dotnet build --configuration Release` and `dotnet run` from an individual modernized project directory. Console exercises may require an interactive terminal.

GitHub Actions checks every project independently and uploads per-project build logs. Known archive failures are reported explicitly; a published project is not automatically a passing project. See the verification report for observed outcomes. A build pass is not a functional test or GUI test.

## Authenticity

The `originals/` source, project files and resources match the reviewed ZIP byte for byte. That ZIP was already sanitized and is not a pristine copy of the original assessment submissions. In particular, two formative projects contain invalid redacted namespaces. Existing modernized source differs from the archive and is labelled separately. Documentation and automation were prepared with AI assistance; no missing solutions were invented. Lecturer handouts, private data, generated binaries and editor state are excluded.

A [separate compatibility helper](docs/REDACTION_COMPATIBILITY.md) builds temporary namespace-repaired copies of Formative 04 and 05 without changing the archive. Its results are distinguished from original builds.
