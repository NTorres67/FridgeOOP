using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    public class Fridge
    {
        // fields
        private bool isClean;
        private string dispenserType;
        private int foodAmount;
        private bool bulbsWork;


        //Properties { get = allows to see value, set =  allows to assign value }
        public bool IsClean
        {
            get { return this.isClean; }
            set { this.isClean = value; }

        }

        public string DispenserType
        {
            get { return this.dispenserType; } //no set prevents you from changing the DispenserType to be set in "Properties"
        }

        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }

        public bool BulbsWork
        {
            get { return this.bulbsWork; }
            set { this.bulbsWork = value; }
        }

        
        //Constructors == allow us to build an object that can be used in another class
        public Fridge()
        {
            this.dispenserType = "basic water dispenser"; // sets value for dispenserType (no set value listed above)
        }

        public Fridge(string dispenserType)
        {
            this.dispenserType = dispenserType;
        }

        public Fridge(bool isClean, string dispenserType, int foodAmount, bool bulbsWork)
        {
            this.isClean = isClean;
            this.dispenserType = dispenserType;
            this.foodAmount = foodAmount;
            this.bulbsWork = bulbsWork;
        }

        //Methods()
        //I need a way to dispense water
        public void DispenseWater() //kep typing, red squigglly linke will clear itself
        {
            if (dispenserType == "basic water dispenser")
            {
                Console.WriteLine("Here's some lukewarm water.");
            }
            else if (dispenserType == "deluxe dispenser") 
            {
                Console.WriteLine("Enjoy your perfect ice water.");
            }
            else 
            {
                Console.WriteLine("What's gonna come out? It's a surprise!");
            }
        }

        //Do I need to change the bulb?
        public string ChangeBulbs()
        {
            if (bulbsWork == false)
            {
                bulbsWork = true;
                return "The bulbs have been changed.";
            }
            else
            {
                return "The bulbs don't have to be changed.";
            }
            
        }

        // Food Removal
        public void RemoveFood(int foodRemoved) // takes parameters but does not return anything
        {
            foodAmount -= foodRemoved; // -= means decreasing amount
        }


        // Check amount of food
        public string CheckSupplies()
        {
            if (foodAmount >= 80)
            {
                return "fully stocked";
            }
            else if (foodAmount > 40)
            {
                return "getting low";
            }
            else
            {
                return "time to grocery shop";
            }
        }


        //Does the fridge need to be cleaned?
        public string Clean() // user inputs "true" go to line 126, else go to line 129
        {
            if (isClean == false)
            {
                isClean = true; 
                return "I cleaned the fridge.";
            } 
            else
            {
                return "The fridge is already clean.";
            }

        }

        ////To stop program
        //public string StopProgram
    }
}
