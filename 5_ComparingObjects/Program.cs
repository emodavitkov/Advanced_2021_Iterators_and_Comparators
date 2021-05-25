using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person("AA",20,"DD");
            //Person person2 = new Person("BB",20,"DD");
            ////Person person1 = new Person("AA",20,"DD");

            //Console.WriteLine(person1.CompareTo(person2));


            List<Person> people = new List<Person>();

            string[] input = Console.ReadLine().Split();
            while (input[0] != "END")
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];
                Person person = new Person(name, age, town);
                people.Add(person);

                input = Console.ReadLine().Split();
            }

            int number = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (var person in people)
            {
                if (person.Equals(people[number - 1]))
                {
                    count++;
                }
            }

            if (count <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{count} {people.Count - count} {people.Count}");
            }
        }
    }
}
