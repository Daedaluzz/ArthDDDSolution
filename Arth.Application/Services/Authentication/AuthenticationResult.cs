
using Arth.Domain.Entities;

namespace Arth.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token);
