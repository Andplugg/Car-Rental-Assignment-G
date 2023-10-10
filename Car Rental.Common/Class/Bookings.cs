using Car_Rental.Common.Enums;
using Car_Rental.Common.Interface;

namespace Car_Rental.Common.Class;

public class Bookings : IBookings
{
    public IVehicle Vehicle { get; set; }
    public IPerson Customer { get; set; }
    public int KmRented { get; set; }
    public int? KmReturned { get; set; }
    public DateOnly DateRented { get; set; }
    public DateOnly? DateReturned { get; set; }

    public Bookings(IVehicle vehicle, IPerson person, int kmRented, int? kmReturned, DateOnly dateRented, DateOnly? dateReturned)
    {
        Vehicle = vehicle;
        Customer = person;
        KmRented = kmRented;
        KmReturned = kmReturned;
        DateRented = dateRented;
        DateReturned = dateReturned;
    }

    public int? Cost()
    {
        if (DateReturned == null || KmReturned == null) return null;
        var daysRented = DateReturned.Value.DayNumber - DateRented.DayNumber;
        daysRented = daysRented == 0 ? 1 : daysRented;
        var dayPrice = daysRented * Vehicle.CostDay;
        var rangeCost = (KmReturned.Value - KmRented) * Vehicle.CostKm;

        return Convert.ToInt32(dayPrice + rangeCost);
    }
}
