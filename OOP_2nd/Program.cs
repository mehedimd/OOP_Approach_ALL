using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2nd
{
    enum VehicleType
    {
        TwoWheeler = 2,
        ThreeWheeler = 3,
        FourWheeler = 4
    }
    interface IInterior
    {
        void DesignInterior(Car car);
    }

    interface IExterior
    {
        void DesignExterior(Motorcycle motorcycle);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose vehicle:");
            Console.WriteLine("Press '4' for car or Press '2' for motorcycle");
            int vehicleType = int.Parse(Console.ReadLine());
            #region Car Calling
            if (vehicleType == (int)VehicleType.FourWheeler)
            {
                Car ocaar = new Car();
                Console.WriteLine("Put Car Model Number:");
                ocaar.ModelNo = Console.ReadLine();
                Console.WriteLine("Put Car Make Year:");
                ocaar.YearMake = int.Parse(Console.ReadLine());
                Console.WriteLine("Put Car Engine Capacity CC:");
                ocaar.EngineCapacityCC = int.Parse(Console.ReadLine());
                Console.WriteLine("Put Car Milage:");
                ocaar.MilagePowerNM = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Number Of Door:");
                ocaar.NumberOfDoor = int.Parse(Console.ReadLine());
                Console.WriteLine("Number Of Gear:");
                ocaar.NumberOfGear = int.Parse(Console.ReadLine());
                IInterior iInterior = new FourWheeler();
                iInterior.DesignInterior(ocaar);
            }
            #endregion
            #region Motorcycle Calling
            else if (vehicleType == (int)VehicleType.TwoWheeler)
            {
                Motorcycle oMotorcycle = new Motorcycle();
                Console.WriteLine("Put Motorcycle Model Number:");
                oMotorcycle.ModelNo = Console.ReadLine();
                Console.WriteLine("Put Motorcycle Make Year:");
                oMotorcycle.YearMake = int.Parse(Console.ReadLine());
                Console.WriteLine("Put Motorcycle Engine Capacity CC:");
                oMotorcycle.EngineCapacityCC = int.Parse(Console.ReadLine());
                Console.WriteLine("Put Motorcycle  MilagePower NM:");
                oMotorcycle.MilagePowerNM = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Put Motorcycle  Maximum Power in BPH:");
                oMotorcycle.BPH = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Put Motorcycle  Mileage in KMPL:");
                oMotorcycle.KMPL = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Put Number Of  Cooling:");
                oMotorcycle.Cooling = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Put Number Of Gear:");
                oMotorcycle.NumberOfGear = int.Parse(Console.ReadLine());
                Console.WriteLine("Put Number Of Front Break:");
                oMotorcycle.FrontBreak = int.Parse(Console.ReadLine());
                Console.WriteLine("Put Number Of Rear Gear:");
                oMotorcycle.RearBreak = int.Parse(Console.ReadLine());
                IExterior iExterior = new TwoWheeler();
                iExterior.DesignExterior(oMotorcycle);
            }
            #endregion
            else
            {
                Console.WriteLine("vehicle not found.");
            }

            Console.ReadKey();

        }
    }
}
