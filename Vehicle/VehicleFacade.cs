using FacadePattern.Vehicle.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Vehicle
{
    class VehicleFacade
    {
        private ControlSystem mControlSystem = null;

        private EnergySystem mEnergySystem = null;

        private LocomotionSystem mLocomotionSystem = null;

        private SafetySystem mSafetySystem = null;

        public VehicleFacade()
        {
            mControlSystem = new ControlSystem();
            mEnergySystem = new EnergySystem();
            mLocomotionSystem = new LocomotionSystem();
            mSafetySystem = new SafetySystem();
        }

        public void Start(Key key)
        {

        }

        public void Request()
        {

        }

        public void End()
        {

        }
    }
}
