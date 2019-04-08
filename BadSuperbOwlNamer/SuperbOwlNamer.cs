using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSuperbOwlNamer
{
    public class SuperbOwlNamer
    {

        // Split the input number into an array of numbers and identify each number by it's decimal place value
        public string indexOfDecimalPlaces(int userInputNumber)
        {
            var numberArray = userInputNumber.ToString().ToCharArray();

            var numberInOnesPlace = int.Parse(numberArray[numberArray.Length - 1].ToString());
            var numberInTensPlace = int.Parse(numberArray[numberArray.Length - 2].ToString());
            var numberInHundredsPlace = int.Parse(numberArray[numberArray.Length - 3].ToString());
            var numberInThousandsPlace = int.Parse(numberArray[numberArray.Length - 4].ToString());

            var romanifyOnes = romanNumeraler1(numberInOnesPlace);
            var romanifyTens = romanNumeraler10(numberInTensPlace);
            var romanifyHundreds = romanNumeraler100(numberInHundredsPlace);
            var romanifyThousands = romanNumeraler1000(numberInThousandsPlace);

            if (numberArray.Length == 1)
            {
                return romanifyOnes;
            }
            else if (numberArray.Length == 2)
            {
                return romanifyTens + romanifyOnes;
            }
            else if (numberArray.Length == 3)
            {
                return romanifyHundreds + romanifyTens + romanifyOnes;
            }
            else if (numberArray.Length == 4)
            {
                return romanifyThousands + romanifyHundreds + romanifyTens + romanifyOnes;
            }
            else
            {
                return null;
            }
        }

        // Change the number in the decimal one's place to a roman numeral
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

        // Change the number in the decimal ten's place to a roman numeral
        public string romanNumeraler10(int stuffToRomanify)
        {
            string name = "";

            if (stuffToRomanify <= 3)
            {
                name = tenToThirty(stuffToRomanify, name);
                return name;
            }
            else if (stuffToRomanify == 4)
            {
                return "XL";
            }
            else if (stuffToRomanify <= 8)
            {
                int remainder = stuffToRomanify - 5;
                name = "L" + tenToThirty(remainder, name);
                return name;
            }
            else if (stuffToRomanify == 9)
            {
                return "XC";
            }
            else
            {
                return name;
            }
        }

        // Change the number in the decimal hundred's place to a roman numeral
        public string romanNumeraler100(int stuffToRomanify)
        {
            string name = "";

            if (stuffToRomanify <= 3)
            {
                name = hundredToThreeHundred(stuffToRomanify, name);
                return name;
            }
            else if (stuffToRomanify == 4)
            {
                return "CD";
            }
            else if (stuffToRomanify <= 8)
            {
                int remainder = stuffToRomanify - 5;
                name = "D" + hundredToThreeHundred(remainder, name);
                return name;
            }
            else if (stuffToRomanify == 9)
            {
                return "CM";
            }
            else
            {
                return name;
            }
        }

        // Change the number in the decimal thousands's place to a roman numeral
        public string romanNumeraler1000(int stuffToRomanify)
        {
            string name = "";

            if (stuffToRomanify <= 3)
            {
                name = thousandToThreeThousand(stuffToRomanify, name);
                return name;
            }
            else
            {
                return name;
            }
        }

        // For loop roman numeral I
        public string oneToThree(int number, string name)
        {
            for (int i=0; i<number; i++)
            {
                name += "I";
            }
            return name;
        }

        // For loop roman numeral X
        public string tenToThirty(int number, string name)
        {
            for (int i=0; i<number; i++)
            {
                name += "X";
            }
            return name;
        }

        // For loop roman numeral C
        public string hundredToThreeHundred(int number, string name)
        {
            for (int i=0; i<number; i++)
            {
                name += "C";
            }
            return name;
        }

        // For loop roman numeral M
        public string thousandToThreeThousand(int number, string name)
        {
            for (int i = 0; i < number; i++)
            {
                name += "M";
            }
            return name;
        }
    }
}
