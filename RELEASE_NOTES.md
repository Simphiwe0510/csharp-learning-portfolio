# Release Notes / Quality Gates

## Review branch

This branch contains documentation improvements and an automated .NET 8 build workflow for the existing HourlyWorkerOOP project.

## Submitted coursework archive audit

- 34 ZIP uploads reduced to 9 unique ZIP collections.
- 23 Visual Studio projects identified, 187 organized files total in the offline prepared archive.
- PDF handouts and unrelated Word assignments were excluded from the source-code package.
- A basic case-insensitive scan of 187 packaged files found no student number, surname, email addresses, common local Windows user paths or obvious embedded secret assignment patterns. This is not a comprehensive privacy audit.
- No .NET SDK is installed in the local workspace, so independent builds could not be executed here.
- The remaining 22 project solutions have not been published to GitHub as of this release note.

## Do not merge until

1. GitHub Actions shows the existing .NET 8 build passing.
2. The remaining source projects are moved from the prepared archive into this branch and individual diffs are inspected.
3. All project compatibility concerns (especially .NET Framework / Windows Forms) are documented and verified.
4. User-specific details, lecturer handouts and generated binaries are absent.

Documentation additions are AI-assisted; original authored student source remains distinguished from it.
