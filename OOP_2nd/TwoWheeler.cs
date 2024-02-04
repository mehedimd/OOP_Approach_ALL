using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2nd
{
    class TwoWheeler : Vehicle, IExterior
    {
        public int FrontBreak { get; set; }
        public int RearBreak { get; set; }
        public void DesignExterior(Motorcycle motorcycle)
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("Design " + motorcycle.vehicleTypes + " Motorcycle !!");
            Console.WriteLine("MotorCycle ModelNo:-" + motorcycle.ModelNo);
            Console.WriteLine("MotorCycle MakeYear:-" + motorcycle.YearMake);
            Console.WriteLine("Number Of Seat:-" + motorcycle.NumberOfSeat);
            Console.WriteLine("Engine Capacity:-" + motorcycle.EngineCapacityCC + "CC");
            Console.WriteLine("Maximum Power:-" + motorcycle.BPH + "BPH");
            Console.WriteLine("MileagePower:-" + motorcycle.KMPL + "KMPL");
            Console.WriteLine("MilagePower:-" + motorcycle.MilagePowerNM + "NM");
            Console.WriteLine("Number Of Cooling:-" + motorcycle.FrontBreak);
            Console.WriteLine("Number Of Front Break:-" + motorcycle.FrontBreak);
            Console.WriteLine("Number Of Rear Break:-" + motorcycle.RearBreak);
            Console.WriteLine("=======================================================");
        }
    }

}
