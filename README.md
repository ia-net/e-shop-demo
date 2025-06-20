# .NET & Angular 기반 이커머스 웹 애플리케이션

## 🛠 기술 스택

- **백엔드**: ASP.NET Core Web API (Onion Architecture)
- **프론트엔드**: Angular17
- **데이터베이스**: SQL Server (EF Core 사용), Redis
- **인증 방식**: JWT 
- **스타일링**: Tailwind CSS, Angular Material
- **개발 환경**: Jetbrains Rider, Visual Studio 2022
- **기타 사용 기술**: Specification Pattern, Stripe

## ✨ 주요 기능

- 회원가입 및 로그인
- 상품 목록 조회 및 필터링
- 장바구니 기능
- 결제 흐름 구현
- JWT 기반 인증 및 토큰 유지

## 💻 실행 방법

### 필수 설치
- [.NET SDK](https://dotnet.microsoft.com/ko-kr/download)
- [NVM](https://github.com/coreybutler/nvm-windows)
- [Node.js 및 npm](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)

### 백엔드(API) 실행
```bash
cd API
dotnet run
docker-compose up
```

### 프론트엔드(Angular) 실행
```bash
cd client
npm install
ng serve
```
