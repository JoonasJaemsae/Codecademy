// Storm.cs
using System;

namespace MagicalInheritance
{
    class Storm
    {
        public string Essence
        { get; private set; }

        public bool IsStrong
        { get; private set; }

        public string Caster
        { get; private set; }

        // CONSTRUCTORS

        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            Caster = caster;
            IsStrong = isStrong;
        }

        // METHODS

        public string Announce()
        {
            string strength = "weak";
            if (IsStrong)
            {
                strength = "strong";
            }
            return $"{Caster} cast a {strength} {Essence} storm!";
        }
    }
}
