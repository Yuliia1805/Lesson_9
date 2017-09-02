using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 4, 5, 6, 10, 35, 457, 5, 79 };
            foreach ( int i in mas)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
