# Copilot Instructions for MyMonkeyApp

이 프로젝트는 .NET 9(C# 13) 기반의 콘솔 애플리케이션으로, 원숭이 종 데이터를 관리하고 MCP 서버 및 GitHub와의 연동을 목표로 합니다.

## 주요 아키텍처 및 구조

- **프로젝트 루트**: 모든 코드는 반드시 `MyMonkeyApp` 폴더(및 하위) 내에 작성합니다.
- **솔루션 파일**: `learn-mcp.sln`에서 `MyMonkeyApp` 프로젝트를 관리합니다.
- **엔트리포인트**: `MyMonkeyApp/Program.cs` (현재 템플릿 상태, 추후 메뉴/로직 추가 예정)
- **빌드/실행**: 표준 .NET CLI 사용
  - 빌드: `dotnet build`
  - 실행: `dotnet run --project MyMonkeyApp`
- **테스트**: 별도 테스트 프로젝트/폴더 없음 (추가 시 `MyMonkeyApp.Tests` 등 명명)

## 개발 패턴 및 규칙

- **C# 코딩 표준**
  - 클래스/메서드/프로퍼티: PascalCase
  - 지역 변수/파라미터: camelCase
  - 상수: 대문자+언더스코어 (`MAX_MONKEYS`)
  - XML 주석: 모든 public 클래스/메서드에 작성
  - `var` 사용: 타입이 명확할 때만
  - async/await 적극 활용
  - 파일 범위 네임스페이스 사용
  - 널러블 참조 타입 활성화

- **아키텍처 패턴**
  - 데이터 관리: 정적 헬퍼 클래스(예: `MonkeyHelper`)와 모델 클래스(`Monkey`)로 분리
  - UI/비즈니스 로직 분리
  - 리포지토리 패턴 권장(데이터 접근 시)
  - 예외 처리: try-catch, IDisposable 구현 필요시 명확히

- **예상되는 주요 클래스/메서드**
  - `MonkeyHelper.GetMonkeys()`, `GetRandomMonkey()`, `GetMonkeyByName()`
  - 모델: `Monkey` (예: `Name`, `Location`, `Population` 프로퍼티)

## 통합 및 외부 연동

- **MCP 서버 및 GitHub 연동**: 추후 구현 예정, 관련 코드는 별도 static helper 또는 service 클래스로 분리
- **외부 패키지**: 현재 명시적 의존성 없음, 필요시 NuGet 패키지 추가

## 기타

- **디렉터리 구조**
  - 빌드 산출물: `MyMonkeyApp/bin/ `MyMonkeyApp/obj/`
  - 소스코드: `MyMonkeyApp/`
- **코드 예시**
  - 클래스/메서드/상수/변수 네이밍은 아래 예시 참고
    - 클래스: `MonkeyHelper`
    - 메서드: `GetMonkeys()`
    - 프로퍼티: `Population`
    - 변수: `selectedMonkey`
    - 상수: `DEFAULT_POPULATION`

---

이 문서에 누락되었거나 불명확한 부분이 있다면 알려주세요. 추가로 반영하겠습니다.