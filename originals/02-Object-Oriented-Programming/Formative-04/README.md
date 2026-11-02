# Formative-04 — Rectangle and Box

Demonstrates inheritance, constructors and overridden geometry methods.

This is the reviewed 2025 coursework archive version, targeting **.NET Framework 4.7.2**. Source, solution, project configuration and resources are byte-preserved from the supplied ZIP. Documentation was added for this portfolio. The archive had already been sanitized before upload.

Build on Windows using Visual Studio Build Tools/MSBuild and the .NET Framework 4.7.2 developer pack:

```powershell
msbuild "Formative4.csproj" /t:Rebuild /p:Configuration=Release /p:Platform=AnyCPU
```

Open the solution in Visual Studio to run the console program. Use an interactive terminal; many exercises pause with Console.ReadKey().

Build results are recorded in the root verification report and GitHub Actions. Compilation alone does not validate behavior.

## Known limitations from source review

The reviewed ZIP contains an invalid namespace with the literal [STUDENT_ID_REDACTED] placeholder. This is a sanitization defect in the supplied archive; it is preserved here, not attributed to the original student submission. Compilation is expected to fail. Box.isSquare() checks length against height only.
