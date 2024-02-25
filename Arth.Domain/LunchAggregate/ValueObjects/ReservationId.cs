using Arth.Domain.Common.Models;

namespace Arth.Domain.LunchAggregate.ValueObjects
{
    public sealed class ReservationId : ValueObject
    {
        public Guid Value { get; }

        private ReservationId(Guid value)
        {
            Value = value;
        }

        public static ReservationId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public static ReservationId Create(Guid value)
        {
            return new(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}

