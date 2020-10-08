using System;
using PeopleClassLibary;

namespace UseOfDelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person();
            me.Age = 58;
            me.Name = "Håkan";
            me.OnBirthDay = Celebrate;
            me.OnBirthDay += YearOfBirth;
            me.YearIncreased();

            Person you = new Person();
            you.Age = 59;
            you.Name = "Micke";
            you.OnBirthDay = Celebrate;

            you.YearIncreased();
        }

        static void Celebrate(Person p)
        {
            if(p.Age % 10 == 0)
                Console.WriteLine($"Grattis {p.Name} du fyller jämna år det vill säga {p.Age} år");
            else
                Console.WriteLine($"Grattis {p.Name} du fyller {p.Age} år");
        }

        static void YearOfBirth(Person p)
        {
            Console.WriteLine($"{p.Name} är född år {DateTime.Now.Year - p.Age}");
        }
    }
}
