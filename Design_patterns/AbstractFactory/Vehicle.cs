using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.AbstractFactory
{
    public abstract class Vehicle
    {
        protected Vehicle(string modelName, Size size)
        {
            ModelName = modelName;
            Size = size;
        }

        public string ModelName { get; set; }
        public Size Size { get; set; }
    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }

    public class SmallVehicle : Vehicle
    {
        public SmallVehicle(string modelName, Size size) : base(modelName, size) { }
    }

    public class MediumVehicle : Vehicle
    {
        public MediumVehicle(string modelName, Size size) : base(modelName, size) { }
    }

    public class LargeVehicle : Vehicle
    {
        public LargeVehicle(string modelName, Size size) : base(modelName, size) { }
    }

    public class VehicleCreator
    {
        public static Vehicle Create(string modelName, Size size)
        {
            switch (size)
            {
                case Size.Small:
                    return new SmallVehicle(modelName,size);
                case Size.Medium:
                    return new MediumVehicle(modelName,size);
                case Size.Large:
                    return new LargeVehicle(modelName,size);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
