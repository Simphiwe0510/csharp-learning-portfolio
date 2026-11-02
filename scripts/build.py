"""Attempt every project in one family and retain per-project evidence."""
import argparse
import json
import os
from pathlib import Path
import subprocess
import sys

parser = argparse.ArgumentParser()
parser.add_argument('family', choices=['originals', 'modernized'])
args = parser.parse_args()
root = Path(__file__).resolve().parents[1]
os.chdir(root)
output = root / 'build-results' / args.family
output.mkdir(parents=True, exist_ok=True)
results = []
for number, project in enumerate(sorted(Path(args.family).rglob('*.csproj')), 1):
    command = (['msbuild', str(project), '/t:Rebuild', '/p:Configuration=Release',
                '/p:Platform=AnyCPU', '/nologo'] if args.family == 'originals' else
               ['dotnet', 'build', str(project), '--configuration', 'Release', '--nologo'])
    try:
        run = subprocess.run(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT,
                             text=True, encoding='utf-8', errors='replace', timeout=180)
        code, log = run.returncode, run.stdout
    except (OSError, subprocess.TimeoutExpired) as error:
        code, log = 125, str(error)
    filename = f'{number:02d}.log'
    (output / filename).write_text(log, encoding='utf-8')
    result = {'project': project.as_posix(), 'exit_code': code,
              'status': 'PASS' if code == 0 else 'FAIL', 'log': filename}
    results.append(result)
    print(f'{result["status"]}: {project}', flush=True)
    if code:
        print(log[-6000:], flush=True)
(output / 'results.json').write_text(json.dumps(results, indent=2) + '\n')
summary = '| Project | Build | Exit code |\n|---|---|---|\n'
summary += ''.join(f'| {x["project"]} | {x["status"]} | {x["exit_code"]} |\n' for x in results)
(output / 'summary.md').write_text(summary)
if os.environ.get('GITHUB_STEP_SUMMARY'):
    with open(os.environ['GITHUB_STEP_SUMMARY'], 'a', encoding='utf-8') as stream:
        stream.write(summary)
if not results:
    sys.exit('No projects found')
sys.exit(1 if any(x['exit_code'] for x in results) else 0)
