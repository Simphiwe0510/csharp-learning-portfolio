"""Verify source integrity, project inclusions and absence of build debris."""
import hashlib
import json
from pathlib import Path
import xml.etree.ElementTree as ET

root = Path(__file__).resolve().parents[1]
manifest = json.loads((root / 'docs/original-sha256.json').read_text())
for name, digest in manifest.items():
    assert hashlib.sha256((root / name).read_bytes()).hexdigest() == digest, name
originals = list((root / 'originals').rglob('*.csproj'))
modernized = list((root / 'modernized').rglob('*.csproj'))
assert len(originals) == 22 and len(modernized) == 4
for project in originals:
    tree = ET.parse(project)
    assert tree.find('.//{*}TargetFrameworkVersion').text == 'v4.7.2', project
    for node in tree.iter():
        include = node.attrib.get('Include')
        if include and node.tag.rsplit('}', 1)[-1] in {'Compile', 'EmbeddedResource', 'None'}:
            assert (project.parent / include.replace('\\', '/')).is_file(), (project, include)
for path in (root / 'originals').rglob('*'):
    assert not ({'bin', 'obj', '.vs'} & set(path.relative_to(root).parts)), path
    assert path.suffix.lower() not in {'.exe', '.dll', '.pdb', '.suo', '.user', '.pdf', '.docx'}, path
print(f'PASS: {len(manifest)} archive files match SHA-256; 22 originals, 4 modernized; project references exist.')
