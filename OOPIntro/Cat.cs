using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Cat
    {
        // inside of our class, we create the blueprint for our object
        // classes are templates in OOP that we use to create objects
        // they should always be named in Pascal case
        // make sure class name is not already used or name of built-in class

        // in OOP, there are two types of states:

        // fields - variables that belong to a class

        private string name; // this is a field
        private int age;
        private string furColor;
        private bool isHungry = true;

        // properties - mix between a field and a method that allow controlled access
        public string Name
            {
                get {return this.name; }
                set { this.name = value; }
            }

        // we also have behaviors:
        // methods - repeatable/reusable sections of code; actions
        // constructors - specialized methods that are used when instantiating an object
        //              - allow us to control the state of an object
        //              - allow us to perform any actions the object might need upon creation
        //              - always share the name of the class

        public Cat() // this is a default constructor - it takes no arguments or parameters
        {

        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
                
        }
    }
}
