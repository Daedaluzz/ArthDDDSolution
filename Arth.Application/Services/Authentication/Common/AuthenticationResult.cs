using Arth.Domain.Entities;

namespace Arth.Application.Services.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);
