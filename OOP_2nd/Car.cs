using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2nd
{
    sealed class Car : FourWheeler
    {
        public Car()
        {
            vehicleTypes = VehicleType.FourWheeler;
            NumberOfSeat = 5;
        }
    }


}
