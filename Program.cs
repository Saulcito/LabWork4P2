using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Second Task");
            Console.WriteLine("Select array size");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            { 
                array[i] = rnd.Next(-3, 11);
            }

            Console.WriteLine("Exit of numbers");
            foreach (int num in array) 
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < size; i++) 
            {
                if (array[i] > 0) //just positive numbers
                {
                    for (int z = 0; z < size; z++) 
                    {
                        if (array[z] == - array[i]) 
                        {
                            array[z] = - array[z];
                        }
                    }
                }
            }

            Console.WriteLine("Modified array");
            foreach (int num in array) 
            {
                Console.Write(num + " ");
            }

            Console.ReadKey(); 
        }
    }
}
