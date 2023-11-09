// Mage.cs
using System;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        // CONSTRUCTORS

        public Mage(string title) : base(title)
        {
            Title = title;
        }

        // METHODS

        public virtual Storm CastRainStorm()
        {
            Storm storm = new Storm("rain", false, Title);
            return storm;
        }
    }
}
