namespace Car_Rental.Common.Interface;

public interface IBookings
{
    public IVehicle Vehicle { get; set; }
    public IPerson Customer { get; set; }
    public int KmRented { get; set; }
    public int? KmReturned { get; set; }
    public DateOnly DateRented { get; set; }
    public DateOnly? DateReturned { get; set; }
    public int? Cost();
}