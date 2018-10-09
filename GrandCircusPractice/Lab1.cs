using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusPractice
{
    class Lab1
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {

                    Console.WriteLine("Enter the length of your room.");
                    string length = Console.ReadLine();
                    Console.WriteLine("Enter the width of your room.");
                    string width = Console.ReadLine();
                    Console.WriteLine("Enter the height of your room.");
                    string height = Console.ReadLine();

                    double roomLength = double.Parse(length);
                    double roomWidth = double.Parse(width);
                    double roomHeight = double.Parse(height);

                    double area = roomLength * roomWidth;
                    double perimeter = roomWidth * 2 + roomLength * 2;
                    double volume = roomLength * roomWidth * roomHeight;

                    Console.WriteLine("The area of your room is " + area + ". The perimeter is " + perimeter + ". The volume is " + volume + ".");

                    Console.WriteLine("Would you like to check another room? Enter 'yes' or 'no'.");
                    string keepGoing = Console.ReadLine();

                    if (keepGoing.ToLower() == "no")
                    {
                        break;
                    }

                }
                catch(FormatException)
                {
                    Console.WriteLine("That is not a valid input.");
                }
            }
            

        }
    }
}
