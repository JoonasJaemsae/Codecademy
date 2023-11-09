// Pupil.cs
using System;

namespace MagicalInheritance
{
    class Pupil
    {
        public string Title
        { get; protected set; }

        // CONSTRUCTORS

        public Pupil(string title)
        {
            Title = title;
        }

        // METHODS

        public Storm CastWindStorm()
        {
            Storm storm = new Storm("wind", false, Title);
            return storm;
        }
    }
}
