using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSuperbOwlNamer
{
    public class SuperbOwlNamer
    {
        public string indexOfDecimalPlaces(int userInputNumber)
        {
            var numberArray = userInputNumber.ToString().ToCharArray();
            if (numberArray.Length == 1)
            {
                var numberInOnesPlace = int.Parse(numberArray[numberArray.Length - 1].ToString());
                var romanifyOnes = romanNumeraler1(numberInOnesPlace);
                return romanifyOnes;
            }
            else if (numberArray.Length == 2)
            {
                var numberInOnesPlace = int.Parse(numberArray[numberArray.Length - 1].ToString());
                var romanifyOnes = romanNumeraler1(numberInOnesPlace);
                var numberInTensPlace = int.Parse(numberArray[numberArray.Length - 2].ToString());
                var romanifyTens = romanNumeraler10(numberInTensPlace);
                return romanifyTens + romanifyOnes;
            }
            else
            {
                return null;
            }
            // var numberInHundredsPlace = int.Parse(numberArray[(numberArray.Length - 3)]);
        }

        public string romanNumeraler1(int stuffToRomanify)
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
            }
            else if (stuffToRomanify == 9)
            {
                return "IX";
            } else
            {
                return name;
            }
        }

        public string romanNumeraler10(int stuffToRomanify)
        {
            string name = "";

            if (stuffToRomanify <= 30)
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
            }
            else if (stuffToRomanify == 9)
            {
                return "IX";
            }
            else
            {
                return name;
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
