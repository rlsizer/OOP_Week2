using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instantiate Person class; pass corresponding arguments/parameters into it
            Person person1 = new Person("Ryan",23,"Cleveland");
            person1.Greeting();
            Console.WriteLine();

            Person person2 = new Person("Abby", 28, "NYC", "BLT");
            person2.Greeting();
            Console.WriteLine();

            //Instantiate default constructor
            Person person3 = new Person();
            person3.Greeting();



        }
    }
}
