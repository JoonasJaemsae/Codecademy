using System;

namespace LearnInheritance
{
    class Truck : Vehicle, IAutomobile
    {
        public override string Describe()
        {
            return $"This {GetType().Name} is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }

        public double Weight
        { get; }

        public Truck(double speed, double weight) : base(speed)
        {
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

    }
}