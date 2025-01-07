using System.Reflection;
using System;

namespace labb_4_grupp_46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gender gender = Gender.Male;
            Hair hair = new Hair { Color = "Brown", Length = 2 };
            DateTime birthday = new DateTime(1993, 6, 29);
            string eyecolor = "Green";
            Person person = new Person(gender, hair, birthday, eyecolor);

            Console.WriteLine(person.ToString());
        }
    }
}
