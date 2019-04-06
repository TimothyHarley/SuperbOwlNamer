using System;

namespace BadSuperbOwlNamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You Have a Superb Owl.  We should name it.  What number is it?");
            int input;
            try
            {
                input = int.Parse(Console.ReadLine());
                var romanNumeral = new SuperbOwlNamer().indexOfDecimalPlaces(input);
                Console.WriteLine($"Your Superb Owl's name is {romanNumeral}. Press Enter to Exit.");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("You Fucked up.  That wasn't a number.  Now your Superb Owl doesn't get a name.");
                Console.ReadLine();
            }
        }
    }
}
