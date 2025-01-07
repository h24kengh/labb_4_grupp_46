using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb_4_grupp_46
{
    public class Person
    {
        public Gender TheGender { get; set; }

        public Hair TheHair { get; set; }

        public DateTime Birthday { get; private set; }

        public string EyeColor { get; private set; }

        public Person(Gender gender, Hair hair, DateTime birthday, string eyeColor)
        {
            TheGender = gender;
            TheHair = hair;
            Birthday = birthday;
            EyeColor = eyeColor;

        }
        public override string ToString()
        {
            return $"Gender: {TheGender}" +
                 $"\nHair colour {TheHair.Color} \nHair length (in cm): {TheHair.Length} " +
                 $"\nBirthday: {Birthday:yyyy/MM/dd}" +
                 $"\nEye color: {EyeColor}";

        }
    }
}
