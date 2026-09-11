using GymOS.Api.Authentication;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGymOsAuthentication(builder.Configuration);

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/health/live", () => Results.Ok(new
{
    status = "live",
    service = "GymOS.Api"
})).AllowAnonymous();

app.MapGet("/health/ready", () => Results.Ok(new
{
    status = "ready",
    service = "GymOS.Api"
})).AllowAnonymous();

app.Run();

public partial class Program
{
}