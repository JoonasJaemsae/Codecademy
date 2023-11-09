// Archmage.cs
using System;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        // CONSTRUCTORS

        public Archmage(string title) : base(title)
        {
            Title = title;
        }

        // METHODS

        public override Storm CastRainStorm()
        {
            Storm storm = new Storm("rain", true, Title);
            return storm;
        }

        public Storm CastLightningStorm()
        {
            Storm storm = new Storm("lightning", true, Title);
            return storm;
        }
    }
}
