            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace HydroelectricDam
    {
        class Program
        {
            static void Main(string[] args)
            {
                int flowRate;// declaring value
                int minFlow = 70; // mininum Flowrate
                int maxFLow = 150; // Maxisimum Flowrate

                Console.WriteLine("What is the Flow Rate?"); 
                if (int.TryParse(Console.ReadLine(), out flowRate)) // integer tryparses out as flowrate
                {
                    if (flowRate < minFlow) //if value less than 70 give a warning of "LOW"
                    {
                        Console.WriteLine("***Warning!! :Flow Rate Low");
                        Console.WriteLine("Opening intake");

                    }

                    else if (flowRate > maxFLow)//if value bigger than 150 give a warning of "HIGH"
                    {
                        Console.WriteLine("***Warning!! : Flow Rate too High");
                        Console.WriteLine("Closing intake");

                    }
                    else // otherwise keep things stady
                    {
                        Console.WriteLine("Flow Rate OK");
                        Console.WriteLine("Normal flow");
                    }

                }
                else // making sure that gives a correct value which an interger not string or double
            {
                Console.WriteLine("Enter Correct Value");
            }

                /*
                 A'NIL EROL
                 20.06.2020
                 Hydroelectric Dam
                 It show the flow rate of the Hydroelectric Dam. As you put level of the flow rate it show the status of the flow rate and has function to close and open the intake.      
                 */
            }

        }
    }

    

