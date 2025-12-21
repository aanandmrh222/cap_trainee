using System;
namespace Day03
{
    public class Person
    {
        public void PersonDet(string name, int age, string city="Jalandhar", char gender='M')
        {
            Console.WriteLine($"Name {name}, age {age}, city {city}, gender {gender}");
        }
    }
}