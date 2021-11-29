using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.AbstractFactory
{
    public class VehicleRescueLargeSizeFactory : VehicleRescueFactory
    {
        public override Vehicle CreateVehicle(string modelName, Size size)
        {
            return VehicleCreator.Create(modelName, size);
        }

        public override Wrecker CreateWrecker()
        {
            return WreckerCreator.Create(Size.Large);
        }
    }
}
