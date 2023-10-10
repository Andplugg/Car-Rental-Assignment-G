using Car_Rental.Common.Enums;
using Car_Rental.Common.Interface;

namespace Car_Rental.Data.Interface;

public interface IData
{
    IEnumerable<IPerson> GetPersons();
    IEnumerable<IVehicle> GetVehicles();
    IEnumerable<IBookings> GetBookings();
}
