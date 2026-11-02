"""Build temporary namespace-repaired copies; never modify the archive."""
import json
import os
from pathlib import Path
import shutil
import subprocess
import sys
import tempfile

root = Path(__file__).resolve().parents[1]
output = root / 'build-results' / 'redaction-compatibility'
output.mkdir(parents=True, exist_ok=True)
projects = [
    'originals/02-Object-Oriented-Programming/Formative-04/Formative4.csproj',
    'originals/03-Exception-Handling/Formative-05/Formative5.csproj',
]
results = []
for name in projects:
    original = root / name
    with tempfile.TemporaryDirectory(prefix='coursework-compat-') as staging:
        project_dir = Path(staging) / original.parent.name
        shutil.copytree(original.parent, project_dir,
                        ignore=shutil.ignore_patterns('bin', 'obj', '.vs'))
        changed = []
        for path in project_dir.rglob('*'):
            if path.suffix not in {'.cs', '.csproj'}:
                continue
            data = path.read_bytes()
            repaired = data.replace(b'[STUDENT_ID_REDACTED]', b'StudentIdRedacted')
            if repaired != data:
                path.write_bytes(repaired)
                changed.append(path.relative_to(project_dir).as_posix())
        assert len(changed) == 4, changed  # three C# files and one RootNamespace
        command = ['msbuild', str(project_dir / original.name), '/t:Rebuild',
                   '/p:Configuration=Release', '/p:Platform=AnyCPU', '/nologo']
        try:
            run = subprocess.run(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT,
                                 text=True, encoding='utf-8', errors='replace', timeout=180)
            code, log = run.returncode, run.stdout
        except (OSError, subprocess.TimeoutExpired) as error:
            code, log = 125, str(error)
        (output / (original.stem + '.log')).write_text(log, encoding='utf-8')
        results.append({'archive_project': name, 'status': 'PASS' if code == 0 else 'FAIL',
                        'exit_code': code, 'temporary_files_changed': changed,
                        'repair': '[STUDENT_ID_REDACTED] -> StudentIdRedacted'})
        print(f'{results[-1]["status"]}: temporary redaction-compatible {name}', flush=True)
        if code:
            print(log[-6000:])
(output / 'results.json').write_text(json.dumps(results, indent=2) + '\n')
summary = '## Temporary redaction compatibility builds\n\n'
summary += 'Archive files remain unchanged. Only the invalid namespace token is replaced in temporary copies.\n\n'
summary += '\n'.join(f'- {x["archive_project"]}: **{x["status"]}**' for x in results) + '\n'
if os.environ.get('GITHUB_STEP_SUMMARY'):
    with open(os.environ['GITHUB_STEP_SUMMARY'], 'a', encoding='utf-8') as stream:
        stream.write(summary)
sys.exit(1 if any(x['exit_code'] for x in results) else 0)
