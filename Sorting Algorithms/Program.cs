using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>();
            List<int> sorted;
            Random rnd = new Random();
            string fileName = "report.csv";

            //variable to save all the data to the file
            FileStream writeStream;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;

            //timer for each sorting algorithm
            Stopwatch sw = new Stopwatch();
            Stopwatch swM = new Stopwatch();
            Stopwatch swB = new Stopwatch();
            Stopwatch swI = new Stopwatch();


            Collection<int> Number = new Collection<int>(unsorted);

            try
            {
               
            }catch(Exception e)
            {
                Console.WriteLine("File couldn't be saved!");
                Console.WriteLine(e.Message);
                return;
            }
            //Streams all the data out
          

            for(int i = 0; i <= 10000; i++)
            {
               
            }

            
            for(int m = 1; m <= 100; m++)
            {
                
            }
            

           


           
            //Bubble Sort Algorithm Records
           
            for (int b = 1; b <= 100; b++)
            {
               
            }
           
            //Insertion Sort Algorithm Records
            
            

            //stops the record
         

            //indicates the user that is completed
           
        }


        private static List<int> BubbleSort(List<int> list)
        {
            
        }

        private static List<int> InsertSort(List<int> list)
        {

        }

        private static List<int> MergeSort(List<int> list)
        {
            
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
           
            }
        }
    }
}
