using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Week2
{
    class Person
    {

        //Class attributes/variables
        public string name;
        public int age;
        public string hometown;
        public string favFood;

        //Default constructor method
        public Person()
        {

        }

        //Constructor method
        //Keyword 'this' always refers to fields/attributes at top
        public Person(string name, int age, string hometown)
        {
            this.name = name;
            this.age = age;
            this.hometown = hometown;
            

        }

        //Constructor method with additional attribute
        public Person(string name, int age, string hometown, string favFood)
        {
            this.name = name;
            this.age = age;
            this.hometown = hometown;
            this.favFood = favFood;
        }

        
        public void Greeting()
        {
            Console.WriteLine("\r\n\r\nHello, my name is " + name+".");
            Console.WriteLine("\r\nI'm " + age + " years old and I'm from " + hometown + ".");
            Console.WriteLine("\r\nMy favorite food is " + favFood+".");
        }




    }
}
