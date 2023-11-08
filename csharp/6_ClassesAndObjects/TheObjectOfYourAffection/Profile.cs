using System;

namespace DatingProfile
{
    class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        // CONSTRUCTORS

        public Profile(string name, int age, string city, string country, string pronouns, string[] hobbies)
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = hobbies;
        }

        public Profile(string name, int age, string city, string country, string pronouns) : this(name, age, city, country,
        pronouns, new string[] { })
        {
        }

        public Profile(string name, int age, string city, string country) : this(name, age, city, country,
        "they/them", new string[] { })
        {
        }

        // METHODS

        public string ViewProfile()
        {
            string hobbiesAsString = String.Join(" ", hobbies);
            string[] list = new string[] { name, age.ToString(), city, country, pronouns, hobbiesAsString };
            string allInfo = String.Join(" ", list);
            return allInfo;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}
