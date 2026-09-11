using GymOS.Api.Authentication;

namespace GymOS.Api.Tests.Authentication;

public class JwtOptionsTests
{
    [Fact]
    public void Defaults_UseShortAccessTokensAndLimitedRefreshTokens()
    {
        var options = new JwtOptions();

        Assert.Equal(15, options.AccessTokenLifetimeMinutes);
        Assert.Equal(30, options.RefreshTokenLifetimeDays);
    }
}