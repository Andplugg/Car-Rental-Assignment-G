using Car_Rental.Common.Interface;

namespace Car_Rental.Common.Class;

public class Customer : IPerson
{
    public string SSN { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }

    public Customer(string sSN, string fName, string lName) =>
        (SSN, FName, LName) = (sSN, fName, lName);
}