using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.AbstractFactory
{
    public class AbstractFactoryExecution
    {
        public static void Execute()
        {
            var recueVehicles = new List<Vehicle>
            {
                VehicleCreator.Create("Jetta", Size.Medium),
                VehicleCreator.Create("Celta", Size.Small),
                VehicleCreator.Create("BMW X6", Size.Large)
            };

            recueVehicles.ForEach(v => VehicleRescue.CreateVehicleRescue(v).MakeRescue());
        }
    }
}
