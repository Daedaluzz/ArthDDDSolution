using Arth.Domain.Common.Models;
using Arth.Domain.GuestAggregate.ValueObjects;
using Arth.Domain.Menu.ValueObjects;

namespace Arth.Domain.GuestAggregate.Entities;

public sealed class Rating : Entity<RatingId>
{
    public HostId HostId { get; }
    public LunchId LunchId { get; }
    public float Value { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }
    private Rating(
        RatingId ratingId,
        HostId hostId,
        LunchId lunchId,
        float value,
        DateTime createdDateTime,
        DateTime updatedDateTime)
        : base(ratingId)
    {
        HostId = hostId;
        LunchId = lunchId;
        Value = value;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Rating Create(
        HostId hostId,
        LunchId lunchId,
        float value)
    {
        return new(
        RatingId.CreateUnique(),
        hostId,
        lunchId,
        value,
        DateTime.UtcNow,
        DateTime.UtcNow);
    }
}
