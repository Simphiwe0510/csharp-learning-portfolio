# Verification and publication report

Verified 2026-11-02. All 22 original archive projects are published under originals/. Four pre-existing .NET 8 versions are retained separately under modernized/. This is 23 distinct exercises and 26 project versions, not 26 different coursework exercises.

## Automated results

[Full Windows/Linux build run](https://github.com/Simphiwe0510/csharp-learning-portfolio/actions/runs/41489051611), source commit `35da64a385106214f0b510ee7d8ecd329246b84a`:

- Original .NET Framework 4.7.2: **20 passed, 2 failed**, Windows Server 2022 / Visual Studio MSBuild.
- Existing modernized .NET 8 projects: **4 passed**, Ubuntu / .NET SDK.
- Archive integrity: **passed**, all 152 non-README archive files match SHA-256; 22 original and four modernized project files; explicit source and resource paths exist.
- All 207 remote blobs at the initial publication commit matched the prepared local bytes. Previously published C# source/project/solution Git blob hashes were unchanged by relocation.

The workflow is deliberately red when the two exact archive projects fail. These failures are not hidden or marked as passing. Per-project logs, results.json and summaries are downloadable as workflow artifacts. No local C# compiler was available, so compiler results come from GitHub-hosted runners.

| Exact original project | Build result |
|---|---|
| [originals/01-Programming-Fundamentals/Tutorial-02/Question 1/Question 1.csproj](originals/01-Programming-Fundamentals/Tutorial-02/Question%201/Question%201.csproj) | **PASS** |
| [originals/01-Programming-Fundamentals/Tutorial-02/Question 2/Question 2.csproj](originals/01-Programming-Fundamentals/Tutorial-02/Question%202/Question%202.csproj) | **PASS** |
| [originals/01-Programming-Fundamentals/Tutorial-02/Question 3/Question 3.csproj](originals/01-Programming-Fundamentals/Tutorial-02/Question%203/Question%203.csproj) | **PASS** |
| [originals/02-Object-Oriented-Programming/Formative-04/Formative4.csproj](originals/02-Object-Oriented-Programming/Formative-04/Formative4.csproj) | **FAIL** |
| [originals/02-Object-Oriented-Programming/Tutorial-06/Question 1/Question 1.csproj](originals/02-Object-Oriented-Programming/Tutorial-06/Question%201/Question%201.csproj) | **PASS** |
| [originals/02-Object-Oriented-Programming/Tutorial-06/Question 2/Question 2.csproj](originals/02-Object-Oriented-Programming/Tutorial-06/Question%202/Question%202.csproj) | **PASS** |
| [originals/02-Object-Oriented-Programming/Tutorial-06/Question 3/Question 3.csproj](originals/02-Object-Oriented-Programming/Tutorial-06/Question%203/Question%203.csproj) | **PASS** |
| [originals/02-Object-Oriented-Programming/Tutorial-06/Question 4/Question 4.csproj](originals/02-Object-Oriented-Programming/Tutorial-06/Question%204/Question%204.csproj) | **PASS** |
| [originals/02-Object-Oriented-Programming/Tutorial-06/Question 5/Question 5.csproj](originals/02-Object-Oriented-Programming/Tutorial-06/Question%205/Question%205.csproj) | **PASS** |
| [originals/03-Exception-Handling/Formative-05/Formative5.csproj](originals/03-Exception-Handling/Formative-05/Formative5.csproj) | **FAIL** |
| [originals/03-Exception-Handling/Tutorial-08/Question 1/Question 1.csproj](originals/03-Exception-Handling/Tutorial-08/Question%201/Question%201.csproj) | **PASS** |
| [originals/03-Exception-Handling/Tutorial-08/Question 2/Question 2.csproj](originals/03-Exception-Handling/Tutorial-08/Question%202/Question%202.csproj) | **PASS** |
| [originals/03-Exception-Handling/Tutorial-08/Question 3/Question 3.csproj](originals/03-Exception-Handling/Tutorial-08/Question%203/Question%203.csproj) | **PASS** |
| [originals/03-Exception-Handling/Tutorial-08/Question 4/Question 4.csproj](originals/03-Exception-Handling/Tutorial-08/Question%204/Question%204.csproj) | **PASS** |
| [originals/04-File-Handling/Tutorial-09/Question 1/Question 1.csproj](originals/04-File-Handling/Tutorial-09/Question%201/Question%201.csproj) | **PASS** |
| [originals/04-File-Handling/Tutorial-09/Question 3/Question 3.csproj](originals/04-File-Handling/Tutorial-09/Question%203/Question%203.csproj) | **PASS** |
| [originals/04-File-Handling/Tutorial-09/Question 4/Question 4.csproj](originals/04-File-Handling/Tutorial-09/Question%204/Question%204.csproj) | **PASS** |
| [originals/05-Windows-Forms/Tutorial-10/Question 1/Question 1.csproj](originals/05-Windows-Forms/Tutorial-10/Question%201/Question%201.csproj) | **PASS** |
| [originals/05-Windows-Forms/Tutorial-10/Question 2/Question 2.csproj](originals/05-Windows-Forms/Tutorial-10/Question%202/Question%202.csproj) | **PASS** |
| [originals/06-Assessments-and-Projects/Summative-Project/Question 1/Question 1.csproj](originals/06-Assessments-and-Projects/Summative-Project/Question%201/Question%201.csproj) | **PASS** |
| [originals/06-Assessments-and-Projects/Summative-Project/Question 2/Question 2.csproj](originals/06-Assessments-and-Projects/Summative-Project/Question%202/Question%202.csproj) | **PASS** |
| [originals/06-Assessments-and-Projects/Summative-Project/Question 3/Question 3.csproj](originals/06-Assessments-and-Projects/Summative-Project/Question%203/Question%203.csproj) | **PASS** |

| Existing modernized project | Build result |
|---|---|
| [modernized/01-Programming-Fundamentals/Tutorial-02/Question-01/Question01.csproj](modernized/01-Programming-Fundamentals/Tutorial-02/Question-01/Question01.csproj) | **PASS** |
| [modernized/02-Object-Oriented-Programming/Tutorial-06/Question-01/Question01.csproj](modernized/02-Object-Oriented-Programming/Tutorial-06/Question-01/Question01.csproj) | **PASS** |
| [modernized/02-Object-Oriented-Programming/Tutorial-06/Question-02/Question02.csproj](modernized/02-Object-Oriented-Programming/Tutorial-06/Question-02/Question02.csproj) | **PASS** |
| [modernized/HourlyWorkerOOP/AbstractWorker.csproj](modernized/HourlyWorkerOOP/AbstractWorker.csproj) | **PASS** |

## Failure diagnosis and compatibility repair

Formative 04 and Formative 05 fail with CS1514, CS0116 and CS1022 because the supplied reviewed ZIP contains `[STUDENT_ID_REDACTED]` in C# namespace identifiers. This is a redaction defect in the reviewed archive, not evidence that these compiler errors were present in the original student submissions. The exact archived versions remain unchanged.

A [separate compatibility helper](docs/REDACTION_COMPATIBILITY.md) repairs only the placeholder in temporary copies, including RootNamespace, and builds them as .NET Framework 4.7.2. It changes no tracked archive source and fixes no application logic. Both temporary-copy builds passed in [run 41489403804](https://github.com/Simphiwe0510/csharp-learning-portfolio/actions/runs/41489403804), commit `3e519ee7b4964aa53fac76af103c4d2ff581a4f7`. The post-build Windows integrity check exposed Git checkout line-ending conversion; `.gitattributes` now disables text conversion for originals/**. A follow-up Windows integrity check is pending.

## Windows and runtime limitations

All 22 legacy projects were attempted using Windows MSBuild, including all three Windows Forms applications, which compiled successfully. Supported legacy builds/runs require Windows, Visual Studio or Build Tools with the .NET desktop workload and the .NET Framework 4.7.2 targeting pack. Modernized .NET 8 projects build on Linux.

Windows Forms GUI interaction was not tested. Console programs were not interactively exercised; many pause with Console.ReadKey(). Build success does not establish correct calculations, validation or file handling. Project READMEs document visible logic limitations, including the subscriber array mismatch, pizza topping calculation, voucher counter, and file parsing assumptions.

## Publication scope

Every original project physically present in the attached ZIP is included once. Tutorial 09 Question 2 is absent and was not invented. HourlyWorkerOOP is retained once from the existing repository. The three archive/modernized exercise pairs are intentional versions, clearly separated. Root ZIP planning/LinkedIn documents and lecturer material were not imported. Generated binaries, private editor files and runtime data are ignored. See [the audit](docs/PUBLICATION_AUDIT.md) and [complete index](PROJECT_INDEX.md).
