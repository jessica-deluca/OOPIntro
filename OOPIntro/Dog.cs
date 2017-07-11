using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Dog // create a Dog class
    {
        // your dog should have fields for hair length, height, running speed and weight

        private string hairLength;
        private decimal height;
        private int runningSpeed;
        private double weight;
        private bool crap = true;

        // properties

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public decimal Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        // public double BarkVolume { get; set; } // creates a private barkVolume; uses get & set shown above

        public Dog()
        {
            // this is my default constructor
        }

        public Dog(string hairLength, decimal height, int runningSpeed, double weight) // hairLength is the temporary variable/parameter; it equals what this.hairLength equals below
        {
            this.hairLength = hairLength; // in this.hairLenght, hairLength is the private field above
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        // you class should have the following behaviors: run, bark, potty, cuddle

        public int Run()
        {
            Console.WriteLine("Go doggy go!!");
            RunningSpeed -= 1;
            return RunningSpeed;
        }

        public void Bark()
        {
            Console.WriteLine("Bark! Bark! Bark!");
        }

        public void Potty()
        {
            if (crap == true)
            {
                Console.WriteLine("Your dog soiled your carpet.");
            }
            else
            {
                Console.WriteLine("Your dog has to relieve itself.");
            }

        }

        public void Cuddle()
        {
            Console.WriteLine("Aww, doggo is so sweet.");
        }

    }
}
