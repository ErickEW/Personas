using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
           Person Homero = new Person("Homero Simpson");
           Homero.SayHello();
           
           Person Marge = new Person("Marge");
           Marge.SayHello();

           Console.WriteLine(Person.bloodColor);

           Person.PrintRace();
        }
    }
}
