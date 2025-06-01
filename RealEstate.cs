using System.Security.Cryptography.X509Certificates;

public class RealEstate
{
    public string Address { get; set; }
    public int Price { get; set; }
    public int SquareFootage { get; set; }
    public int CalculatePricePerSquareFoot() => Price / SquareFootage;

}