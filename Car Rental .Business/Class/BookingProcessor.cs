using Car_Rental.Common.Class;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interface;
using Car_Rental.Data.Interface;

namespace Car_Rental_.Business.Class;

public class BookingProcessor
{
    private readonly IData _db;

    public BookingProcessor(IData db) => _db = db;

    public IEnumerable<IPerson> GetCustomers()
    {
        return _db.GetPersons();
    }
    public IEnumerable<IVehicle> GetVehicles()
    {
        var vehicles = _db.GetVehicles();
        foreach (var vehicle in vehicles)
        {
            var booked = _db.GetBookings().Any(b => b.Vehicle.RegNR == vehicle.RegNR && !b.DateReturned.HasValue);
            vehicle.VehicleStatus = booked ? VehicleStatuses.Booked : VehicleStatuses.Available;

        }
        return vehicles;
    }
    public IEnumerable<IBookings> GetBookings()
    {
        return _db.GetBookings();
    }
}
