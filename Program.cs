using FacadePattern.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial a vehicle
            VehicleFacade vehicle = new VehicleFacade();

            //Start vehicle
            vehicle.Start(new Key());

            //Control vehicle
            vehicle.Request();

            //End vehicle
            vehicle.End();
        }
    }
}
