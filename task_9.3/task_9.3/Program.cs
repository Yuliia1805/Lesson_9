using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._3
{
    class Program
    {
        struct Person
        {
            public string firstName;
            public int age;
        }
        static void Main(string[] args)
        {
            const int size = 2;
            Person[] persons = new Person[size];
            string[] heads = { "Name", "Age" };

            persons[0].firstName = "Ivan";
            persons[0].age = 18;

            persons[1].firstName = "Oleg";
            persons[1].age = 22;

            for (int i = 0; i < heads.Length; i++)
            {
                Console.Write("|" + heads[i] + "|\t\t");
            }
            Console.WriteLine();

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].firstName + "\t\t" + persons[i].age);
            }
          
            //Console.WriteLine("The person is {0} and he is {1} years old", p.firstName, p.age);




            Console.ReadLine();
        }
    }
}
