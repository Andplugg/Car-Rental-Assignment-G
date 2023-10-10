using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interface;

public interface IVehicle
{
    public string RegNR { get; set; }
    public string Make { get; set; }
    public int Odometer { get; set; }
    public double CostKm { get; set; }
    public VehicleTypes VehicleType { get; set; }
    public int CostDay { get; set; }
    public VehicleStatuses VehicleStatus { get; set; }
}