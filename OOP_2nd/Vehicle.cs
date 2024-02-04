using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2nd
{
    abstract class Vehicle
    {
        public VehicleType vehicleTypes { get; set; }
        public string ModelNo { get; set; }
        public int YearMake { get; set; }
        public int NumberOfSeat { get; set; }
        public int NumberOfGear { get; set; }
        public int EngineCapacityCC { get; set; }
        public decimal MilagePowerNM { get; set; }
    }

}
