using Arth.Domain.Common.Models;

namespace Arth.Domain.LunchAggregate.ValueObjects;

public sealed class Location : ValueObject
{
    public string Name { get; private set; }
    public string Adress { get; private set; }
    public double Latitude { get; private set; }
    public double Longitude { get; private set; }

    private Location(
        string name,
        string adress,
        double latitude,
        double longitude)
    {
        Name = name;
        Adress = adress;
        Latitude = latitude;
        Longitude = longitude;
    }

    public static Location CreateNew(
        string name,
        string adress,
        double latitude,
        double longitude)
    {
        return new(
            name,
            adress,
            latitude,
            longitude);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
        yield return Adress;
        yield return Latitude;
        yield return Longitude;
    }
}
