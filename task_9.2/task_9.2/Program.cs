using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minVal = -100;
            const int maxVal = 100;
            int min;
            int max;
            Console.Write("Enter size of  array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Random rand = new Random();

            for ( int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(minVal, maxVal);
            }
            
           
           /* min = array[0];
            max = array[0];
            for ( int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);

            int[] newArray = new int[size];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = rand.Next(min, max);
            }*/

           /* for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }

                }
                Console.WriteLine("\nSorted array: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }*/

            Console.WriteLine("Original array: ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            int[] reverseArray = new int[size];
            //Array.Reverse(array);
            for( int i = 0; i < reverseArray.Length; i++)
            {
                reverseArray[i] = array[array.Length - i - 1];
            }


            Console.WriteLine("\nReversed array: ");
            for (int i = 0; i < reverseArray.Length; i++)
            {
                Console.Write(reverseArray[i] + " ");
            }

            /*for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }

            }
            Console.WriteLine("\nSorted array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }*/






            Console.ReadLine();
        }
    }
}
