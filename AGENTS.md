# AGENTS.md

This repository follows strict .NET development conventions.

## 1. General Principles

- Follow Clean Architecture principles
- Prefer explicit over implicit behavior
- Avoid unnecessary abstraction
- Write testable and maintainable code
- Keep public APIs stable

---

## 2. Coding Standards

- Target .NET 10
- Nullable reference types enabled
- Use `ArgumentNullException.ThrowIfNull`
- Use `ArgumentOutOfRangeException.ThrowIfNegative`
- Avoid static state unless required
- Follow Microsoft naming conventions

---

## 3. Project Structure

Each package must:

- Have its own `.csproj`
- Include XML documentation
- Contain unit tests
- Avoid cross-layer circular dependencies

---

## 4. Dependency Management

- Use `Directory.Packages.props` for central dependency management
- Avoid unnecessary third-party dependencies
- Prefer Microsoft.Extensions.* abstractions

---

## 5. Versioning Rules

- Follow SemVer
- Breaking changes require major version bump
- Public API changes must be documented

---

## 6. Testing

- Use xUnit (preferred)
- Use FluentAssertions
- Minimum coverage recommended: 80%
- Public APIs must have tests

---

## 7. Packaging Rules

- `GeneratePackageOnBuild` disabled
- Use `dotnet pack -c Release`
- Include:
  - XML docs
  - Symbols package
  - Repository URL
  - License metadata

---

## 8. CI Requirements

Pull Requests must:

- Build successfully
- Pass all tests
- Not decrease coverage significantly

---

## 9. Breaking Change Policy

- Must be clearly documented
- Migration guidance required
- Mark obsolete APIs before removal when possible
