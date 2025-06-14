# .NET Core & Angular 기반 이커머스 웹 애플리케이션

이 리포지터리는 [Udemy 강의](https://www.udemy.com/course/learn-to-build-an-e-commerce-app-with-net-core-and-angular/)를 기반으로 개발된 학습용 프로젝트임을 미리 알리며, 일부 기능은 미완성 상태이거나 예제 수준으로 구성되어 있을 수 있습니다. 자세한 설명과 단계별 구현은 원본 강의를 참고해주세요.

---

## 🛠 기술 스택

- **백엔드**: ASP.NET Core Web API (Onion Architecture)
- **프론트엔드**: Angular  
- **데이터베이스**: SQL Server (EF Core 사용)
- **인증 방식**: JWT 
- **스타일링**: Tailwind, Angular Material  
- **기타 사용 기술**: Specification 패턴

## ✨ 주요 기능 (개발 중)

- 회원가입 및 로그인
- 상품 목록 조회 및 필터링
- 장바구니 기능
- 결제 흐름 구현
- 관리자 페이지 (상품 관리)
- JWT 기반 인증 및 토큰 유지
- 역할 기반 권한 제어

## 💻 실행 방법

### 필수 설치
- [.NET SDK](https://dotnet.microsoft.com/ko-kr/download)
- [Node.js 및 npm](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)
- [docker desktop](https://www.docker.com/products/docker-desktop/)

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
