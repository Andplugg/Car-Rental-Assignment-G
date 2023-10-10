using Car_Rental.Common.Enums;
using Car_Rental.Common.Interface;

namespace Car_Rental.Common.Class;

public class Motorcycle : IVehicle
{
    public string RegNR { get; set; }
    public string Make { get; set; }
    public int Odometer { get; set; }
    public double CostKm { get; set; }
    public VehicleTypes VehicleType { get; set; }
    public int CostDay { get; set; }
    public VehicleStatuses VehicleStatus { get; set; }
    public Motorcycle(string regNR, string make, int odometer, double costKm, VehicleTypes vehicleType, int costDay, VehicleStatuses vehicleStatus)
    {
        RegNR = regNR;
        Make = make;
        Odometer = odometer;
        CostKm = costKm;
        VehicleType = vehicleType;
        CostDay = costDay;
        VehicleStatus = vehicleStatus;
    }
}