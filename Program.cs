using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrinting
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //a)
            int size = 7;
            for ( int row = 0; row < size; row++)
            { 
               for(int col = 0; col < size; col++)
               {
                 if (row == col || row == (size - 1)|| col == (size - 1) || col == 0)
                 {
                 {
                  Console.Write("*");
                 }  
                 }
                 else if (row == 0 || col == (size - 1 - row) || col == 0 || row == (size -1 - col))
                 {
                       Console.Write("*");
                 }
                 else
                {
                  Console.Write(" ");
               }  
               }
               Console.WriteLine(" ");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


            //b)
            char alphabet = 'A';
            for (int i = 0; i < 7; i++)
            {
                for (int j = 7; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int m = 1; m < 7; m++)
                {
                    Console.Write(alphabet);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
             alphabet++;


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
