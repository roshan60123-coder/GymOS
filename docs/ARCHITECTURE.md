# GymOS Architecture

## Product principle

GymOS is a local-first fitness platform. Normal workout, nutrition, progress, and goal tracking must work without an internet connection.

The cloud API is authoritative only for identity, membership, subscriptions, payments, device registration, recovery/sync, and security-sensitive events.

## Projects

### `src/GymOS.Mobile`

The Android and iOS .NET MAUI application.

Responsibilities:

- Member interface
- Secure token storage
- Local SQLite database
- Offline workout, nutrition, progress, and goal workflows
- Local notifications
- Optional on-device AI features

### `src/GymOS.Api`

The ASP.NET Core backend API.

Responsibilities:

- Authentication and account management
- Membership status
- Razorpay checkout, verification, and webhooks
- Device registration
- Optional backup and sync
- Health endpoints and future observability

### `src/GymOS.Domain`

Business concepts and rules shared by the mobile application and API.

Examples to add later:

- Workout calculations
- Personal-record detection
- Nutrition calculations
- Membership rules
- Shared domain entities

This project must not depend on the API, mobile app, or database technologies.

### `src/GymOS.Contracts`

Shared request and response models used by the mobile app and API.

Examples to add later:

- Login requests
- Profile responses
- Membership responses
- Payment checkout responses
- Sync contracts

This project must not depend on other GymOS projects.

### `tests`

Automated tests for domain rules and API behaviour.

## Dependency rules

```text
GymOS.Mobile -> GymOS.Domain
GymOS.Mobile -> GymOS.Contracts

GymOS.Api -> GymOS.Domain
GymOS.Api -> GymOS.Contracts

GymOS.Domain -> no GymOS dependencies
GymOS.Contracts -> no GymOS dependencies