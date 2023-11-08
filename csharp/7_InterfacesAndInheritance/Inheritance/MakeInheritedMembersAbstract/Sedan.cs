using System;

namespace LearnInheritance
{
    class Sedan : Vehicle, IAutomobile
    {
        public override string Describe()
        {
            return $"This {GetType().Name} is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }

        public Sedan(double speed) : base(speed)
        {
            Wheels = 4;
        }

    }
}