var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/health/live", () => Results.Ok(new
{
    status = "live",
    service = "GymOS.Api"
}));

app.MapGet("/health/ready", () => Results.Ok(new
{
    status = "ready",
    service = "GymOS.Api"
}));

app.Run();

/// <inheritdoc/>
public partial class Program
{
}
