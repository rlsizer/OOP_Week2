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

        



    }
}
