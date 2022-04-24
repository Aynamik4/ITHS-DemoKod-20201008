using System;

namespace PeopleClassLibary
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Action<Person> OnBirthDay { get; set; }

        public void IncreaseYear()
        {
            Age++;
            OnBirthDay(this);
        }
    }
}
