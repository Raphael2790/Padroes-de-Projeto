using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.AbstractFactory
{
    public abstract class Wrecker
    {
        protected Wrecker(Size size)
        {
            Size = size;
        }

        public abstract void Rescue(Vehicle vehicle);
        public Size Size { get; set; }
    }

    public class SmallWrecker : Wrecker
    {
        public SmallWrecker(Size size) : base(size) { }
        public override void Rescue(Vehicle vehicle)
        {
            Console.WriteLine("Rescue Small Vehicle - Modelo " + vehicle.ModelName);
        }
    }

    public class MediumWrecker : Wrecker
    {
        public MediumWrecker(Size size) : base(size) { }
        public override void Rescue(Vehicle vehicle)
        {
            Console.WriteLine("Rescue Medium Vehicle - Modelo " + vehicle.ModelName);
        }
    }

    public class LargeWrecker : Wrecker
    {
        public LargeWrecker(Size size) : base(size) { }
        public override void Rescue(Vehicle vehicle)
        {
            Console.WriteLine("Rescue Large Vehicle - Modelo " + vehicle.ModelName);
        }
    }

    public class WreckerCreator
    {
        public static Wrecker Create(Size size)
        {
            switch (size)
            {
                case Size.Small:
                    return new SmallWrecker(size);
                case Size.Medium:
                    return new MediumWrecker(size);
                case Size.Large:
                    return new LargeWrecker(size);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
