
# kr.bbon.packages

**kr.bbon** 계열의 .NET 라이브러리를 하나의 모노레포(Monorepo)로 통합 관리하는 저장소입니다.

본 저장소는 다음을 목표로 합니다:

- 패키지 버전 일관성 유지
- CI/CD 통합 관리
- 의존성 중앙 관리
- 패키지 간 리팩터링 용이성 확보
- 릴리즈 프로세스 단순화

---

## 📦 포함된 패키지

- **kr.bbon.Core**
- **kr.bbon.AspNetCore**
- **kr.bbon.EntityFrameworkCore.Extensions**
- **kr.bbon.Services**
- **kr.bbon.Data**
- **kr.bbon.Azure.Translator.Services**

각 패키지는 독립적으로 NuGet 배포가 가능합니다.

---

## 🏗 저장소 구조

```
/src
  /kr.bbon.Core
  /kr.bbon.AspNetCore
  /kr.bbon.EntityFrameworkCore.Extensions
  /kr.bbon.Services
  /kr.bbon.Data
  /kr.bbon.Azure.Translator.Services

/tests
  /kr.bbon.Core.Tests
  /kr.bbon.AspNetCore.Tests
  ...

/build
/docs
```

---

## 🎯 대상 프레임워크

- .NET 8 (LTS)
- 필요 시 .NET Standard 병행 지원

---

## 🚀 빌드

```bash
dotnet restore
dotnet build
```

---

## 📦 패키지 생성

```bash
dotnet pack -c Release
```

출력 경로:

```
/artifacts
```

---

## 🔢 버전 전략

- SemVer (Semantic Versioning)
- 패키지별 독립 버전 관리
- `Directory.Packages.props` 기반 중앙 의존성 관리 권장

---

## 🔁 CI/CD 구성

권장 파이프라인 단계:

1. Restore
2. Build
3. Test
4. Pack
5. NuGet 또는 GitHub Packages 배포

---

## 🤝 기여 방법

1. 기능 브랜치 생성
2. 테스트 작성
3. 전체 테스트 통과 확인
4. Pull Request 제출

---

## 📜 라이선스

MIT License
