import json
from pathlib import Path
root = Path("Packages")
expected = {"xrcore", "project-doctor", "asset-auditor", "build-optimizer", "editor-tools"}
assert {p.name.removeprefix("com.nexora.") for p in root.iterdir() if p.is_dir()} == expected
for p in root.iterdir():
    if not p.is_dir():
        continue
    data = json.loads((p / "package.json").read_text())
    assert data["name"] == p.name
    for name in ["README.md", "CHANGELOG.md", "Documentation~/index.md"]:
        assert (p / name).is_file(), name
    for sample in data.get("samples", []):
        assert (p / sample["path"]).is_dir()
    for asm in p.rglob("*.asmdef"):
        json.loads(asm.read_text())
    assert list(p.rglob("*.cs"))
print("Package metadata validated; Unity compilation not performed.")
