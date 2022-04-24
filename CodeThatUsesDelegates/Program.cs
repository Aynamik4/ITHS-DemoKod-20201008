// A demostration of the use of delegates.

using System;
using System.Collections.Generic;
using System.Linq;

namespace EventDemo
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person() { Name = "Johansson", Age = 58 },
                new Person() { Name = "Andersson", Age = 85 },
                new Person() { Name = "Jansson", Age = 45 },
                new Person() { Name = "Pettersson", Age = 35 },
                new Person() { Name = "Andersson", Age = 25 },
            };

            //people.Sort(MyComparison); // Named method.
            people.Sort((you, me) => // Lambda expression
            {
                if (string.Compare(you.Name, me.Name) < 0)
                    return -1;
                else
                if (string.Compare(you.Name, me.Name) > 0)
                    return 1;
                else
                        if (you.Age < me.Age)
                    return -1;
                else
                    if (you.Age > me.Age)
                    return 1;
                else
                    return 0;
            }
);

            foreach (Person i in people)
            {
                Console.WriteLine($"{i.Name} {i.Age}");
            }

            Console.WriteLine("-------------------------------");

            var peopleOver35 = people
                .Where(p => p.Age > 35)
                .ToList();

            foreach (Person person in peopleOver35)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }

        static int MyComparison(Person you, Person me)
        {
            if (string.Compare(you.Name, me.Name) < 0)
                return -1;
            else
            if (string.Compare(you.Name, me.Name) > 0)
                return 1;
            else
                    if (you.Age < me.Age)
                return -1;
            else
                if (you.Age > me.Age)
                return 1;
            else
                return 0;
        }
    }
}
