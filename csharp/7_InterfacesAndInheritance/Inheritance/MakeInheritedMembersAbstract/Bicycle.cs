using System;

namespace LearnInheritance
{
    class Bicycle : Vehicle
    {
        public override string Describe()
        {
            return $"This {GetType().Name} is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }

        public Bicycle(double speed) : base(speed)
        {
            Wheels = 2;
        }

        public override void SpeedUp()
        {
            Speed += 5;

            if (Speed > 15)
            {
                Speed = 15;
            }
        }

        public override void SlowDown()
        {
            Speed -= 5;

            if (Speed < 0)
            {
                Speed = 0;
            }
        }

    }
}