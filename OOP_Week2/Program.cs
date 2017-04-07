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

            Console.WriteLine(person1.name);


        }
    }
}
