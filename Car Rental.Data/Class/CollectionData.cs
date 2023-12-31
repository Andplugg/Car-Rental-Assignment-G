﻿using Car_Rental.Common.Class;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interface;
using Car_Rental.Data.Interface;

namespace Car_Rental.Data.Class;

public class CollectionData : IData
{
    readonly List<IPerson> _persons = new List<IPerson>();
    readonly List<IVehicle> _vehicles = new List<IVehicle>();
    readonly List<IBookings> _bookings = new List<IBookings>();

    public CollectionData() => SeedData();

    void SeedData()
    {
        _persons.Add(new Customer("12345", "John", "Doe"));
        _persons.Add(new Customer("67890", "John", "Doe"));

        _vehicles.Add(new Car("ABC123", "Volvo", 10000, 1, VehicleTypes.Combi, 200, VehicleStatuses.Available));
        _vehicles.Add(new Car("DEF456", "Saab", 20000, 1, VehicleTypes.Sedan, 100, VehicleStatuses.Available));
        _vehicles.Add(new Car("GHI789", "Tesla", 1000, 3, VehicleTypes.Sedan, 100, VehicleStatuses.Booked));
        _vehicles.Add(new Car("JKL012", "Jeep", 5000, 1.5, VehicleTypes.Van, 300, VehicleStatuses.Available));
        _vehicles.Add(new Motorcycle("MNO234", "Yamaha", 30000, 0.5, VehicleTypes.Motorcycle, 50, VehicleStatuses.Available));

        _bookings.Add(new Bookings(
            _vehicles.First(v => v.RegNR.Equals("GHI789")),
            _persons.First(c => c.SSN.Equals("12345")),
            1000, null, new DateOnly(2023, 09, 20), null));

        _bookings.Add(new Bookings(
            _vehicles.First(v => v.RegNR.Equals("JKL012")),
            _persons.First(c => c.SSN.Equals("67890")),
            5000, 5000, new DateOnly(2023, 09, 20), new DateOnly(2023, 09, 20)));
    }

    public IEnumerable<IPerson> GetPersons() => _persons;
    public IEnumerable<IVehicle> GetVehicles() => _vehicles;
    public IEnumerable<IBookings> GetBookings() => _bookings;
}
