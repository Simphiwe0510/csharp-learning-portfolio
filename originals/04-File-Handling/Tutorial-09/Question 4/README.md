# Tutorial-09/Question 4 — Student records

Provides a menu to add, save, reload and display weighted student marks.

This is the reviewed 2025 coursework archive version, targeting **.NET Framework 4.7.2**. Source, solution, project configuration and resources are byte-preserved from the supplied ZIP. Documentation was added for this portfolio. The archive had already been sanitized before upload.

Build on Windows using Visual Studio Build Tools/MSBuild and the .NET Framework 4.7.2 developer pack:

```powershell
msbuild "Question 4.csproj" /t:Rebuild /p:Configuration=Release /p:Platform=AnyCPU
```

Open the solution in Visual Studio to run the console program. Use an interactive terminal; many exercises pause with Console.ReadKey().
Files are relative to the working directory; use a writable exercise directory and fictional input data.

Build results are recorded in the root verification report and GitHub Actions. Compilation alone does not validate behavior.

## Known limitations from source review

The file format is a simple comma split with no escaping or malformed-record validation. Use fictional student details only.
