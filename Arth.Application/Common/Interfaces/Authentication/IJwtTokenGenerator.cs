
using Arth.Domain.Entities;

namespace Arth.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
