using Arth.Application.Common.Interfaces.Authentication;
using System.Security.Claims;
using Microsoft.IdentityModel.JsonWebTokens;

namespace Arth.Infrastructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    public string GenerateToken(Guid userId, string firstName, string lastName)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

        };
    }
}
