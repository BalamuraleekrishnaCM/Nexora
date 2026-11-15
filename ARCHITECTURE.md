# Nexora modular Unity toolkit architecture

## Supported editor versions
Unity 2022.3 LTS and Unity 6 LTS; validate both in CI before release. Keep runtime assemblies platform-agnostic, and isolate UnityEditor dependencies in Editor assemblies.

## Repository layout
```
Packages/
  com.nexora.xrcore/
  com.nexora.project-doctor/
  com.nexora.asset-auditor/
  com.nexora.build-optimizer/
  com.nexora.editor-tools/
.github/workflows/
docs/
```
Each package owns package.json, Runtime/, Editor/, Tests/, Samples~/, Documentation~/, README.md, CHANGELOG.md, LICENSE.md, and asmdefs where applicable.

## Dependencies and isolation
XR Core contains only XR abstractions and optional OpenXR integration. Project Doctor reads project configuration and emits non-destructive diagnostics. Asset Auditor scans assets read-only by default. Build Optimizer generates reports and opt-in fixes, never changes PlayerSettings without explicit confirmation. Editor Tools supplies menu actions and reusable windows. Avoid circular package references.

## Quality gates
For every package: validate package.json metadata and semver; compile Editor and runtime asmdefs; execute EditMode tests; import Samples~ into a clean project; run Unity 2022.3 and Unity 6 matrix; verify UPM Git URL installation; attach changelog and release notes. Never mark a package released without these checks.

## Versioning
Use independent SemVer tags per package, e.g. com.nexora.xrcore/v0.1.0. Keep breaking changes in major versions. Publish releases only after tests pass.
