using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSuperbOwlNamer
{
    public class SuperbOwlNamer
    {
        public string romanNumeraler(int stuffToRomanify)
        {
            string name = "";


            if (stuffToRomanify <= 3)
            {
                name = oneToThree(stuffToRomanify, name);
                return name;
            }
            else if (stuffToRomanify == 4)
            {
                return "IV";
            }
            else if (stuffToRomanify <= 8)
            {
                int remainder = stuffToRomanify - 5;
                name = "V" + oneToThree(remainder, name);
                return name;
            } else
            {
                return "IX";
            }
        }

        public string oneToThree(int number, string name)
        {
            for (int i = 0; i < number; i++)
            {
                name += "I";
            }
            return name;
        }
    }
}
