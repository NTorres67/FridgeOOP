using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an interactive console window
            // Prompt user to choose what to do with the fridge
            // Call methods on Fridge object to do what the user wants

            int userChoice;

            do
            {

                Console.WriteLine("Hello, welcome to the fridge app.");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1.");
                Console.WriteLine("To change light bulb, type 2.");
                Console.WriteLine("To clean, type 3.");
                Console.WriteLine("To take food, type 4.");
                Console.WriteLine("To check food supplies, type 5.");
                Console.WriteLine("To see all fridge details, type 6");
                //Console.WriteLine("To restart, type 7.");
                Console.WriteLine("To quit, type 8.");
                Console.WriteLine("");

                userChoice = int.Parse(Console.ReadLine());

                Fridge userFridge = new Fridge(false, "delux dispenser", 70, true); //(dispense water,            ,  

                int foodRemoved = 0;

                switch(userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        break;

                    case 2:
                        Console.WriteLine(userFridge.ChangeBulbs());                       
                        break;

                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;

                    case 4:
                        userFridge.CheckSupplies();
                        //Console.WriteLine(userFridge.RemoveFood);
                        userFridge.RemoveFood(foodRemoved -= 70);
                        break;

                    case 5:
                        Console.WriteLine(userFridge.CheckSupplies());
                        break;

                    case 6:
                        Console.WriteLine(userFridge);
                        break;

                    //case 7: ..................OPTIONAL TO PUT IN
                    //    break;

                    case 8:
                        Console.WriteLine("Thank you for using the fridge app.");
                        Console.ReadLine();
                        break;

                }
                Console.WriteLine("");




            } while (userChoice != 8);
        }
    }
}
