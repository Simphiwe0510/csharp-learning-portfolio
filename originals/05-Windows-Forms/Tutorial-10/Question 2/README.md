# Tutorial-10/Question 2 — Pizza calculator

Windows Forms exercise using size, crust and topping controls.

This is the reviewed 2025 coursework archive version, targeting **.NET Framework 4.7.2**. Source, solution, project configuration and resources are byte-preserved from the supplied ZIP. Documentation was added for this portfolio. The archive had already been sanitized before upload.

Build on Windows using Visual Studio Build Tools/MSBuild and the .NET Framework 4.7.2 developer pack:

```powershell
msbuild "Question 2.csproj" /t:Rebuild /p:Configuration=Release /p:Platform=AnyCPU
```

Open the solution in Visual Studio to run the Windows Forms application. GUI execution requires Windows; automated compilation does not test the UI.

Build results are recorded in the root verification report and GitHub Actions. Compilation alone does not validate behavior.

## Known limitations from source review

The topping logic adds a fixed amount rather than charging per selected topping, and also adds a topping amount when none is selected.
