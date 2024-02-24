using Arth.Application.Common.Interfaces.Services;

namespace Arth.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
