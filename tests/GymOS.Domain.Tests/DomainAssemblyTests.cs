using GymOS.Domain;

namespace GymOS.Domain.Tests;

public class DomainAssemblyTests
{
    [Fact]
    public void DomainAssembly_IsAvailable()
    {
        Assert.NotNull(typeof(DomainAssemblyMarker).Assembly);
    }
}