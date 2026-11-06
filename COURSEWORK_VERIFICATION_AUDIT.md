# Original C# Coursework — Verification Audit (2026-11-02)

This audit covers the locally prepared `UJ-CSharp-Portfolio-Complete-Reviewed.zip` collection. **It does not mean these files are all uploaded to GitHub or build-tested.**

## Verified from the archive

- ZIP integrity check: passed (no CRC errors).
- 22 original Visual Studio C# project files (`.csproj`), each with a corresponding solution (`.sln`).
- 77 C# source files, 22 application configuration files, and supporting project resources/documentation.
- All 22 original project files target **.NET Framework 4.7.2**.
- Every explicitly referenced `<Compile Include="...">` source path resolves to a file in the archive (no missing explicitly listed C# compilation files detected).
- 2 tutorial Windows Forms projects plus a Windows Forms summative question were identified.
- Various console projects contain `Console.ReadKey()` or basic numeric parsing that needs interactive/manual testing; file-handling projects require filesystem testing.

## Not yet verified

- No original .NET Framework 4.7.2 project has been compiled by this audit; the available container does not have the `dotnet` SDK or Windows .NET Framework build tools.
- Windows Forms visual layout, runtime events, and compatibility have **not** been tested.
- Source inspection and ZIP integrity are not substitutes for runtime or behavioural verification.
- Original ZIP project directories use names such as `Question 1`; some previously published .NET 8 adaptations use `Question-01`. Do not treat those adapted projects as equivalent binary/build verification for the originals.
- The ZIP has not been bulk-pushed to GitHub. This report is a local-archive audit, not a GitHub completeness claim.

## Review practice

Keep student code intact. Where improvements are desirable, document or introduce a separately labelled refactored version. Check for sensitive data and course-assessment publication restrictions before making source public. Use a Windows runner with .NET Framework 4.7.2 targeting packs to verify the original projects and avoid classifying unrun projects as 'passing'.
