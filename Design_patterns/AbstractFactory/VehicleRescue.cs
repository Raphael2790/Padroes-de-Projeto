using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.AbstractFactory
{
    public class VehicleRescue
    {
        private readonly Vehicle _vehicle;
        private readonly Wrecker _wrecker;
        public VehicleRescue(VehicleRescueFactory factory, Vehicle vehicle)
        {
            _vehicle = factory.CreateVehicle(vehicle.ModelName, vehicle.Size);
            _wrecker = factory.CreateWrecker();
        }

        public void MakeRescue()
        {
            _wrecker.Rescue(_vehicle);
        }

        public static VehicleRescue CreateVehicleRescue(Vehicle vehicle)
        {
            switch (vehicle.Size)
            {
                case Size.Small:
                    return new VehicleRescue(new VehicleRescueSmallSizeFactory(), vehicle);
                case Size.Medium:
                    return new VehicleRescue(new VehicleRescueMediumSizeFactory(), vehicle);
                case Size.Large:
                    return new VehicleRescue(new VehicleRescueLargeSizeFactory(), vehicle);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
