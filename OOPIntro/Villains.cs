using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Villains
    {
        private string costumes;
        private string name;
        private string evilPowers;
        private int strengthLevel;

        public string Costumes { get; set; } // prop tab twice is shortcut
        public string Name { get; set; }
        public string EvilPowers { get; set; }
        public int StrengthLevel { get; set; }

        public Villains() // ctor tab twice is shortcut
        {
            // this is our default - what will be returned if no parameters
            Random random = new Random();
            this.costumes = "A bed sheet";
            this.name = "A really bad dude";
            this.evilPowers = "I can control empty boxes";
            this.strengthLevel = random.Next(0, 51);
        }

        public Villains(string name, string costumes, int strengthLevel)
        {
            // this is what will be returned if the above parameters are set
            this.name = name;
            this.costumes = costumes;
            this.evilPowers = GetPowers();
            this.strengthLevel = strengthLevel;
        }

        public string GetPowers()
        {
            string[] powers = { "Killer farts", "Mind control", "Throwing fire", "Words that can kill", "Evil laugh" };
            Random random = new Random();
            string newPower = powers[random.Next(0, powers.Length)];
            return newPower;
        }



    }
}
