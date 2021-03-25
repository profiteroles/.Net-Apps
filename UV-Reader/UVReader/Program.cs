using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UVReader
{
    class Program
    {
        static void Main(string[] args)
        {
            int UVIndex; //UV value
            bool keyBoardInput;
            Console.WriteLine("Please type your UV Level 1 to 20");// Question comes on the console to direct user
            keyBoardInput = int.TryParse(Console.ReadLine(), out UVIndex);//Input parses to UVIndex
            if (UVIndex <= 10 && UVIndex > 0) // Condition if it's less than 11 apply cases
            {
                switch (UVIndex)
                {
                    case 1:
                    case 2:Console.WriteLine("Green : LOW"); break;
                    case 3:
                    case 4:
                    case 5:Console.WriteLine("Yellow : Moderate"); break;
                    case 6:
                    case 7:Console.WriteLine("Orange : High"); break;
                    case 8:
                    case 9:
                    case 10:Console.WriteLine("Red : Very High"); break;
                    default:Console.WriteLine("That value does not compute!"); break;
                }
            }
            else if (UVIndex >= 11 && UVIndex < 21 ) // if it's between 11 & 20 apply condition below
            {
                Console.WriteLine("Purple : Extreme"); // write on console Extreme
            }
            else
            {
                Console.WriteLine("That value does not compute! Please Enter Value between 1 to 20"); // otherwise give an Error Message
            }
        }
    }
}
/*A'NIL EROL
 * 30023737
 * 28.07.2020
 */
