using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    static class GlazerApp
    {
        public static void RunExample()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("What is the width? ");
            widthString = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
            width = double.Parse(widthString);
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("What is the height? ");
            heightString = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
            height = double.Parse(heightString);
#pragma warning restore CS8604 // Possible null reference argument.
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
        }
    }
}
