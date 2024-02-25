using Arth.Domain.Common.Models;
using Arth.Domain.GuestAggregate.Entities;
using Arth.Domain.GuestAggregate.ValueObjects;
using Arth.Domain.Menu.ValueObjects;

namespace Arth.Domain.MenuReviewAggregate;
public sealed class MenuReview : AggregateRoot<MenuReviewId>
{
    public Rating Rating { get; }
    public string Comment { get; }
    public HostId HostId { get; }
    public MenuId MenuId { get; }
    public GuestId GuestId { get; }
    public LunchId LunchId { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private MenuReview(
        MenuReviewId menuReviewId,
        string comment,
        HostId hostId,
        MenuId menuId,
        GuestId guestId,
        LunchId dinnerId,
        DateTime createdDateTime,
        DateTime updatedDateTime)
        : base(menuReviewId)
    {
        Comment = comment;
        HostId = hostId;
        MenuId = menuId;
        GuestId = guestId;
        LunchId = dinnerId;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static MenuReview Create(
        string comment,
        HostId hostId,
        MenuId menuId,
        GuestId guestId,
        LunchId dinnerId)
    {
        return new(
            MenuReviewId.CreateUnique(),
            comment,
            hostId,
            menuId,
            guestId,
            dinnerId,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
}
