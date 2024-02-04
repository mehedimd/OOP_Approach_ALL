using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2nd
{
    class FourWheeler : Vehicle, IInterior
    {
        public int NumberOfDoor { get; set; }
        public void DesignInterior(Car car)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Design " + car.vehicleTypes + " Is Car!!");
            Console.WriteLine("Car ModelNo:-" + car.ModelNo);
            Console.WriteLine("Car MakeingYear:-" + car.YearMake);
            Console.WriteLine("Engine Capacity:-" + car.EngineCapacityCC);
            Console.WriteLine("Number Of Seat:-" + car.NumberOfSeat);
            Console.WriteLine("Number  Of Door:-" + car.NumberOfDoor);
            Console.WriteLine("Number Of Gear:-" + car.NumberOfGear);
            Console.WriteLine("=============================================");
        }
    }

}
