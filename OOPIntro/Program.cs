using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // when we initialize a new object, it is called instantiating (creating an new instance)
            // objects need to be instantiated before they can be used
            // all objects of a specific type are created from the same template - CLASS
            // all objects from a class will have the same number and type of states, but each instance can have its own unique values

            // the format we use to instantiate an object looks like this:
            // ClassName objectName = new ClassName();

            Cat firstCat = new Cat(); // to create a new object, we use a special method called a constructor; Cat() is calling the constructor in our main method

            firstCat.Name = "Mittens";

            Cat secondCat = new Cat("Oz", 3, "Orange and white");
            secondCat.Name = "Ozzy";
            Console.WriteLine(secondCat.Name);
            Console.WriteLine(secondCat.Age);
            secondCat.Eat();

            // thinking about objects in real life, create 3 examples of objects
            // objects should have 5 states (characteristics) and 5 behaviors

            // Object 1: Coffee

            // States:
            // hasCaffeine
            // color
            // water
            // beans
            // madeWithCoffeeMaker

            // Behaviors:
            // GetsHot()
            // GetsCold()
            // Pours
            // GetsDrinken()
            // MadeInMorning()

            // Object 2: Water bottle

            // States:
            // color
            // hasStraw
            // insulated
            // containsWater
            // size

            // Behaviors:
            // KeepsWaterCold()
            // ContainsLiquid()
            // DispensesWater()
            // DoesNotSpillLiquid()
            // UsedbyHumans()



        }
    }
}
