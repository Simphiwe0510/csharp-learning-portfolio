# Verification and publication report

Prepared 2026-11-02. All 22 original projects from the reviewed ZIP are included, together with the four previously published modernized versions. See PROJECT_INDEX.md for exact paths and docs/PUBLICATION_AUDIT.md for provenance.

Local archive integrity: passed SHA-256 comparison for every imported non-README archive file, project counts and explicit source/resource inclusion checks. No local C# compiler or .NET SDK is installed. Compilation uses the repository workflow: Windows MSBuild for all 22 originals and Ubuntu .NET 8 for all four modernized versions.

Build execution is pending at this commit. Results will be updated after the workflow completes. The two formative projects are expected to fail due to literal redaction placeholders in namespaces in the supplied ZIP. The preservation policy keeps these exact archive sources. Successful compilation is not a behavior test; console interaction and Windows Forms GUI testing have not been performed.

Windows is required for supported legacy .NET Framework builds/runs and all three Windows Forms GUIs. Install Visual Studio Build Tools with the .NET desktop workload and .NET Framework 4.7.2 targeting pack; per-project README files include the MSBuild command. Automation attempts every project even after failures and uploads full logs plus machine-readable exit codes.
