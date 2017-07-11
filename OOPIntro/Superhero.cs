using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    class Superhero
    {
        // 4 fields

        private string costume;
        private string name;
        private int strengthLevel;
        private string power;
        private bool hasCape;

        // 4 properties

        public string Costume
        {
            get { return this.costume; }
            set { this.costume = value; }
        }

        public string Name
        {
            get { return this.costume; }
        }

        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }

        public string Power
        {
            get { return this.power; }
        }

        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }

        // 3 constructors

        public Superhero()
        {
           // default constructor
        }

        public Superhero(string name) // if they use this constructor, the strength level will always be 100
        {
            this.name = name;
            this.StrengthLevel = 100;
        }

        public Superhero(string costume, string name, int strengthLevel, string power, bool hasCape)
        {
            this.costume = costume;
            this.name = name;
            this.strengthLevel = strengthLevel;
            this.power = power;
            this.hasCape = hasCape;
        }

        // 2 methods

    }
}
