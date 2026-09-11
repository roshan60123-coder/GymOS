GymOS is a local-first fitness platform for Android and iOS. Members can track workouts, nutrition, progress, and goals offline, while the cloud securely manages accounts, memberships, subscriptions, devices, and payments.

## Planned technology

- Mobile: .NET MAUI and C#
- Local storage: SQLite
- Backend: ASP.NET Core Web API
- Server database: PostgreSQL
- Payments: Razorpay
- Testing: xUnit

## Project structure
text
src/
  GymOS.Mobile/       .NET MAUI mobile application
  GymOS.Api/          ASP.NET Core backend API
  GymOS.Domain/       Shared business rules
  GymOS.Contracts/    Shared API contracts

tests/
  GymOS.Domain.Tests/ Domain-rule tests
  GymOS.Api.Tests/    API tests

docs/
  ARCHITECTURE.md     Architecture and dependency rules
  PROJECT_RULES.md    Team and security rules