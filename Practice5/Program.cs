using Practice5.Extensions;
using Practice5.Models;
using System.Runtime.CompilerServices;

namespace Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isParse = true;
        restart:
            ColorCW.WhiteColor("Bakda neqeder benzin var");
            isParse = double.TryParse(Console.ReadLine(), out double fuel);
            ColorCW.WhiteColor("Bakın tutumunu daxil edin");
            bool isParseT = double.TryParse(Console.ReadLine(), out double tankCopacity);
            ColorCW.WhiteColor("100km-ə nə qədər benzin sərf etdiyini daxil edirik.");
            bool isParseC = double.TryParse(Console.ReadLine(), out double fuelConsumption);
            if (!isParse || !isParseC || !isParseT)
            {
                ColorCW.RedColor("Duzgun ededler daxil edin!!");
                goto restart;
            }
            Car car = new Car(fuel, fuelConsumption, tankCopacity);




            restartSwitch:

            ColorCW.WhiteColor("[1] Sur");
            ColorCW.WhiteColor("[2] Zapravkaya gir");
            ColorCW.WhiteColor("[3] Benzini goster");
            ColorCW.WhiteColor("[4] Getdiyimiz yolu goster");

            char result = Console.ReadKey().KeyChar;
            switch (result)
            {
                case '1':
                    car.Drive(KilometerInsert());
                    break;
                case '2':
                    car.Refuel(RefuelInsert());
                    break;
                case '3':
                    ColorCW.GreenColor("Fuel:" + car.Fuel);
                        break;
                case '4':
                    ColorCW.GreenColor("getdiyiniz yol:" + car.MileAge);
                    break;
                default:
                    break;
            }
            goto restartSwitch;
        }
        public static double KilometerInsert()
        {
            ColorCW.WhiteColor("Nece kilometr yol gedek?");
        restart:
            bool isPArse = double.TryParse(Console.ReadLine(), out double kilometer);
            if (!isPArse)
            {
                ColorCW.RedColor("Duzgun eded daxil edin");
                goto restart;
            }
            return kilometer;

        }
        public static double RefuelInsert()
        {
            ColorCW.WhiteColor("Socara cos gelmisiniz neqeder yanacaq isteyirsiniz");
            rs:
            bool isPase=double.TryParse(Console.ReadLine(),out double refuel);
            if (!isPase)
            {
                ColorCW.RedColor("duzgun eded daxil edin");
                goto rs;
            }
            return refuel;
        }
    }
}