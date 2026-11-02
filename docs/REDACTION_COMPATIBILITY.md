# Redaction compatibility builds

The reviewed ZIP replaced a student identifier with the literal `[STUDENT_ID_REDACTED]` in Formative 04 and 05. Brackets are invalid in a C# namespace. The archive files remain byte-identical; their direct builds fail and are reported as failures.

For a buildable compatibility copy, run this command from the repository root in a Windows developer terminal with Python 3 and MSBuild available:

```powershell
python scripts/build_redaction_compatibility.py
```

The helper copies only these two projects into temporary directories and replaces `[STUDENT_ID_REDACTED]` with `StudentIdRedacted` in three C# namespace declarations and the project RootNamespace for each project. No application logic is repaired, no original identifier is recovered, and no tracked source is rewritten. Temporary sources and binaries are removed automatically. Logs and exit codes are retained under the ignored build-results/redaction-compatibility directory.

This is a compatibility check of transformed copies, not a passing build of the exact archive. GitHub Actions runs it separately from the 22 unmodified original builds and rechecks archive integrity afterwards.
