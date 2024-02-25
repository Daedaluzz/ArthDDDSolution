using Arth.Domain.Common.Models;

namespace Arth.Domain.Menu.ValueObjects;
public sealed class LunchId : ValueObject
{
    public Guid Value { get; }

    private LunchId(Guid value)
    {
        Value = value;
    }

    public static LunchId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
