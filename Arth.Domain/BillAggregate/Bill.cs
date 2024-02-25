using Arth.Domain.BillAggregate.ValueObjects;
using Arth.Domain.Common.Models;
using Arth.Domain.Common.ValueObjects;
using Arth.Domain.GuestAggregate.ValueObjects;
using Arth.Domain.Menu.ValueObjects;

namespace Arth.Domain.BillAggregate;

public sealed class Bill : AggregateRoot<BillId>
{
    public LunchId LunchId { get; }
    public GuestId GuestId { get; }
    public HostId HostId { get; }
    public Price Price { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Bill(
        BillId id,
        GuestId guestId,
        HostId hostId,
        Price price,
        DateTime createdDateTime,
        DateTime updatedDateTime)
        : base(id)
    {
        GuestId = guestId;
        HostId = hostId;
        Price = price;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Bill Create(
        GuestId guestId,
        HostId hostId,
        Price price)
    {
        return new(
            BillId.CreateUnique(),
            guestId,
            hostId,
            price,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
}