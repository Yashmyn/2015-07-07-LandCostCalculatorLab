using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_07_07_LandCostCalculatorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate area (in yards) and perimeter (in feet), and the resulting total cost, of a parcel of land.

            Console.WriteLine();
            Console.WriteLine("LAND-COST CALCULATOR IN A FAR AWAY LAND (where the cost of a parcel of land is determined by both its area (in yards) and its perimeter (in feet).");
            Console.WriteLine();

            Console.WriteLine("Determine the total cost of land (at $5.00 per square yard and $0.75 per foot of the perimeter):");
            Console.WriteLine();

            //ask user for length in feet

            Console.Write("Please enter the LENGTH of the parcel in FEET and then press <Enter>: ");

            //initialize variable for length in feet

            decimal footLength = decimal.Parse(Console.ReadLine());

            //convert length from feet to yards and print

            decimal yardLength = footLength / 3.00m;

            Console.WriteLine("  " + footLength + " feet equals {0:N2} yards.", yardLength);

            Console.WriteLine();

            //ask user for width in feet

            Console.Write("Now please enter the WIDTH of the parcel in FEET and then press <Enter>: ");

            //initialize variable for width in feet

            decimal footWidth = decimal.Parse(Console.ReadLine());

            //convert width from feet to yards and print

            decimal yardWidth = footWidth / 3.00m;

            Console.WriteLine("  " + footWidth + " feet equals {0:N2} yards.", yardWidth);

            Console.WriteLine();

            //calculate and print area and corresponding sub-cost

            decimal squareYard = yardLength * yardWidth;
            decimal costSquareYard = 5.00m * squareYard;
            Console.WriteLine("     The partial cost of this parcel based on square yards is {0:C}.", costSquareYard);
            Console.WriteLine();

            //calculate and print perimeter and corresponding sub-cost

            decimal footPerimeter = 2 * footLength + 2 * footWidth;
            decimal costFootPerimeter = 0.75m * footPerimeter;
            Console.WriteLine("     The partial cost of this parcel based on feet in the perimeter is {0:C}.", costFootPerimeter);
            Console.WriteLine();

            //print total cost

            Console.WriteLine("     The TOTAL COST of this parcel is {0:C}.", costSquareYard + costFootPerimeter);

            Console.ReadLine();
        }
    }
}
