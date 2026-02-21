# kr.bbon.packages

Unified repository for all **kr.bbon** .NET libraries.

This repository consolidates multiple NuGet packages into a single mono-repository to improve:

- Version consistency
- CI/CD management
- Dependency control
- Cross-package refactoring
- Release management

---

## 📦 Included Packages

This repository contains the following libraries:

- **kr.bbon.Core**
- **kr.bbon.AspNetCore**
- **kr.bbon.EntityFrameworkCore.Extensions**
- **kr.bbon.Services**
- **kr.bbon.Data**

Each package remains independently packable and publishable to NuGet.

---

## 🏗 Repository Structure

```
/src
  /kr.bbon.Core
  /kr.bbon.AspNetCore
  /kr.bbon.EntityFrameworkCore.Extensions
  /kr.bbon.Services
  /kr.bbon.Data

/tests
  /kr.bbon.Core.Tests
  /kr.bbon.AspNetCore.Tests
  ...

/build
/docs
```

---

## 🎯 Target Framework

- .NET 10 (LTS)
- .NET Standard (if required per package)

Each project defines its own target framework(s) where necessary.

---

## 🚀 Build

```bash
dotnet restore
dotnet build
```

---

## 📦 Pack

```bash
dotnet pack -c Release
```

Artifacts will be generated under:

```
/artifacts
```

---

## 🔄 Versioning Strategy

- Semantic Versioning (SemVer)
- Independent versioning per package
- Central package version management recommended (`Directory.Packages.props`)

---

## 🔁 CI/CD

Typical pipeline stages:

1. Restore
2. Build
3. Test
4. Pack
5. Publish to NuGet (or GitHub Packages)

---

## 🤝 Contributing

1. Create a feature branch
2. Write tests
3. Ensure all tests pass
4. Submit Pull Request

---

## 📜 License

MIT License
