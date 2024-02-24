using Arth.Domain.Entities;

namespace Arth.Application.Authentication.Common;

public record AuthenticationResult(User User, string Token);
