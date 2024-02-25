using Arth.Domain.BillAggregate.ValueObjects;
using Arth.Domain.Common.Models;
using Arth.Domain.Common.ValueObjects;
using Arth.Domain.GuestAggregate.Entities;
using Arth.Domain.GuestAggregate.ValueObjects;
using Arth.Domain.Menu.ValueObjects;
using Arth.Domain.UserAggregate.ValueObjects;
namespace Arth.Domain.GuestAggregate;

public sealed class Guest : AggregateRoot<GuestId>
{
    private readonly List<LunchId> _upcomingLunchesIds = new();
    private readonly List<LunchId> _pastLunchesIds = new();
    private readonly List<LunchId> _pendingLunchesIds = new();
    private readonly List<BillId> _billsIds = new();
    private readonly List<MenuReviewId> _menuReviewsIds = new();
    private readonly List<Rating> _ratingsIds = new();

    public string FirstName { get; }
    public string LastName { get; }
    public string ProfileImgUrl { get; }
    public AverageRating AverageRating { get; }
    public UserId UserId { get; }

    public IReadOnlyList<LunchId> UpcomingLunchesIds => _upcomingLunchesIds.AsReadOnly();
    public IReadOnlyList<LunchId> PastLunchesIds => _pastLunchesIds.AsReadOnly();
    public IReadOnlyList<LunchId> PendingLunchesIds => _pendingLunchesIds.AsReadOnly();
    public IReadOnlyList<BillId> BillsIds => _billsIds.AsReadOnly();
    public IReadOnlyList<MenuReviewId> MenuReviewsIds => _menuReviewsIds.AsReadOnly();
    public IReadOnlyList<Rating> RatingsIds => _ratingsIds.AsReadOnly();
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Guest(
      GuestId guestId,
      string firstName,
      string lastName,
      string profileImgUrl,
      AverageRating averageRating,
      UserId userId,
      DateTime createdDateTime,
      DateTime updatedDateTime)
      : base(guestId)
    {
        FirstName = firstName;
        LastName = lastName;
        ProfileImgUrl = profileImgUrl;
        AverageRating = averageRating;
        UserId = userId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Guest Create(
        string firstName,
        string lastName,
        string profileImgUrl,
        AverageRating averageRating,
        UserId userId)
    {
        return new(
            GuestId.CreateUnique(),
            firstName,
            lastName,
            profileImgUrl,
            averageRating,
            userId,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
}