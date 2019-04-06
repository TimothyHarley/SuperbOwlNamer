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
            else
            {
                return "V";
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
