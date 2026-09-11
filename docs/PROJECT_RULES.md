Mobile app: .NET MAUI + C#.
API: ASP.NET Core, versioned under /v1.
Fitness activity works offline using SQLite.
Server owns accounts, memberships, payments, devices, and security events.
Never store Razorpay secrets, card data, or server secrets in the mobile app.
Payments will be verified by the server and Razorpay webhooks.
Every feature needs tests before being considered complete.