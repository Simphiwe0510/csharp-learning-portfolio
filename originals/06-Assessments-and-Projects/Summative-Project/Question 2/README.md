# Summative-Project/Question 2 — Corporate subscribers

Uses an abstract subscriber class and corporate payment methods.

This is the reviewed 2025 coursework archive version, targeting **.NET Framework 4.7.2**. Source, solution, project configuration and resources are byte-preserved from the supplied ZIP. Documentation was added for this portfolio. The archive had already been sanitized before upload.

Build on Windows using Visual Studio Build Tools/MSBuild and the .NET Framework 4.7.2 developer pack:

```powershell
msbuild "Question 2.csproj" /t:Rebuild /p:Configuration=Release /p:Platform=AnyCPU
```

Open the solution in Visual Studio to run the console program. Use an interactive terminal; many exercises pause with Console.ReadKey().

Build results are recorded in the root verification report and GitHub Actions. Compilation alone does not validate behavior.

## Known limitations from source review

The subscriber array has six entries but the source arrays have five, causing an index error. The derived setter does not initialize base fields. The computed annualFeeDue is not displayed.
