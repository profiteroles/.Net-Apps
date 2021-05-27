using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int newCode = random.Next(1, 999);
            int doorCode;
            int counter = 0;
            Boolean locked = true;
            Console.WriteLine(newCode);
            try
            {
                do
                {
                    Console.WriteLine("Please Enter 3 digit to Open Door Code!");
                    doorCode = int.Parse(Console.ReadLine());
                    counter++;

                    if (doorCode == newCode)
                    {
                        Console.WriteLine("Correct Password - Door is Opened!");
                        locked = false;
                        Console.BackgroundColor = ConsoleColor.Green;
                    }

                    else if (newCode < doorCode)
                    {
                        Console.WriteLine("Number is too HIGh");
                    }
                    else if (newCode > doorCode)
                    {
                        Console.WriteLine("Number is too LOW");
                    }
                }
                while (counter < 5);
                while (!locked) ;
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter Number not letter & try again");
                Console.ReadLine();
            }
        }
    }
}
