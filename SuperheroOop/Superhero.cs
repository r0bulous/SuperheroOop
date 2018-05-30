using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroOop
{
    class Superhero
    {
        //Declare Fields
        private int strengthLevel;
        private string secretIdentity;
        private string superPower;
        private bool hasCape;

        //Declare Properties

        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }

        public string SecretIdentity
        {
            get { return this.secretIdentity; }
            set { this.secretIdentity = value; }
        }

        public string SuperPower
        {
            get { return this.superPower; }
            set { this.superPower = value; }
            }

        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }

        // Declare constructors

        public Superhero()
        {
            //default constructor
        }

        // loaded constructors
        public Superhero(string superPower, string secretIdentity)
        {
            this.superPower = superPower;
            this.secretIdentity = secretIdentity;
        }
        public Superhero(bool hasCape, int strengthLevel)
        {
            this.hasCape = hasCape;
            this.strengthLevel = strengthLevel;
        }

        public void PowerSource()
        {
            if (strengthLevel < 10)
            {
                strengthLevel++;
            }

            Console.WriteLine("The new strength level is " + strengthLevel + ".");
        }

        public void Foe()
            {
            string foe = " ";
            Console.WriteLine("The present foe this superhero is engaged in conflict is " + foe + ".");
            Console.ReadLine();
            }
         



        }
}
