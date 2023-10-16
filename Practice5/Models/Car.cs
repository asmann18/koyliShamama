using Practice5.Extensions;
using Practice5.Interfaces;
using System.Drawing;

namespace Practice5.Models;

public class Car:IVehicle
{
    public double MileAge { get;private set; }
    public double Fuel { get;private set; }
    public double FuelConsumption { get;private set; }
    public double TankCapacity { get; private set; }
    public Car(double fuel=20,double fuelConsumption=10,double tankCapacity=40)
    {
        Fuel= fuel;
        FuelConsumption= fuelConsumption;
        TankCapacity = tankCapacity;
        MileAge = 0;
        
    }

    public bool Drive(double kilometer)
    {
        var i = FuelConsumption / 100;
        if (i * kilometer < Fuel)
        {

            Fuel-=i*kilometer;
            MileAge += kilometer;
            ColorCW.GreenColor($"Qalan Benzin:{Fuel}\n Gedilen yol:{kilometer}");
            return true;
        }
        ColorCW.RedColor("Bu yolu getmek mumkun deyil");
        return false;
        
    }

    public bool Refuel(double amount)
    {
        if (amount < 0)
        {
            ColorCW.RedColor("Sehv daxil elemisen");
            return false;

        }
        if (amount > TankCapacity - Fuel)
        {
            amount = TankCapacity - Fuel;
            ColorCW.GreenColor($"{amount} dolduruldu.DOldu Fuel{TankCapacity}");
            Fuel = TankCapacity;
        }
        else
        {
            Fuel += amount;
            ColorCW.GreenColor($"{amount} dolduruldu.fuel:{Fuel}");
        }
            return true;
    }
}
