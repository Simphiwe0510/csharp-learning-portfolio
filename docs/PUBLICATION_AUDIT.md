# Publication audit

Input: CSharp-Portfolio (1).zip, containing 182 files and 22 project files. The archive audit's count of 23 includes HourlyWorkerOOP, which is not actually present in the ZIP. All 22 actual archive projects are included once. The original GitHub main commit was 349cbe1388dd8155e9853e29ea8fd0ff7e10ca36.

The ZIP's six category directories were imported under originals/. All non-README files in these directories are byte-identical to the ZIP; docs/original-sha256.json records SHA-256 values. Project READMEs were rewritten after source review. The pre-existing four SDK projects were moved to modernized/ unchanged, including their source. No extra HourlyWorkerOOP copy was created. Three modernized exercises correspond to archive originals and are intentional version pairs.

The ZIP contains no PDFs, Word handouts, bin/obj/.vs folders or binaries. Root ZIP planning documents and LinkedIn material were not imported; stale verification claims were replaced. Source and XML were checked for local user paths, contact information, student numbers and credential patterns; no unredacted private values were found. Runtime prompts for names or IDs are program inputs, not included private records. Windows Forms Designer.cs, Resources.Designer.cs and resx files are necessary checked-in project assets and are preserved.

The reviewed ZIP already replaces student IDs with [STUDENT_ID_REDACTED]. This creates invalid C# namespaces in Formative 04 and 05. Those exact sources remain as evidence of the supplied archive. Compiler failures are documented rather than silently changing coursework. No claim is made that these placeholders were in the student's original submission.

Build tooling was absent in the local Linux environment (dotnet, msbuild and mono). Automated compilation therefore uses GitHub-hosted Windows MSBuild for all originals and Ubuntu .NET 8 for all modernized projects. Every project is attempted even when another fails. See the verification report for actual run evidence.

The archive uses mixed LF/CRLF line endings. `.gitattributes` marks originals/** as non-normalizing (`-text`) so Windows checkouts retain the reviewed bytes. This fixes a checkout configuration defect found by Windows integrity verification; it does not alter source content. The temporary redaction compatibility helper changes only the namespace placeholder in disposable copies.
