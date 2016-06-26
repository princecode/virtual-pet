using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {

        static void Main(string[] args)
        {


            // welcome
            // instructions
            Console.WriteLine("\n\nWAKANDA PANTHER TRAINER\n\nWould you like to train a baby panther totem?\n\nPlease enter \"1\" for \"Yes\" and \"2\" for \"No\"!\n");

            int introSelect = Convert.ToInt32(Console.ReadLine());

            if (introSelect == 1)
            {
                Menu();
            }

            Console.WriteLine("\nThat's unfortunate. Feel free to return at a later time!\n Press any key to exit.");
            Console.ReadKey();

            //private static void Menu()
            //present possible options
            //Create pet class
        }
        private static void Menu()
        {

            Console.WriteLine("\n------------------------------------------------------------------------");
            Console.WriteLine("Wise decision Wakandan soldier! Name your Pather Totem.");
            Pet newPanther = new Pet();
            newPanther.Name = newPanther.PantherName();

            // name test...SUCCESS!<--- add entry confirmation.     
            Console.WriteLine("You've entered {0} is this the name you would like?", newPanther.Name);
            Console.WriteLine("\n\nPlease enter \"1\" for \"Yes\" and \"2\" for \"No\"!\n");

            int nameConf = Convert.ToInt32(Console.ReadLine());

            if (nameConf == 1)
            {
                int menuSelect;
                do
                {

                    Console.WriteLine("\n\n" + newPanther.ToString());
                    Console.WriteLine("\n--------------------------------------------------");
                    Console.WriteLine("XXXXXXXX~~~|XXXXXXXXXXXXXXXXXXXXXXXXXX|~~~XXXXXXXX");
                    Console.WriteLine("--------------------------------------------------\n");
                    Console.WriteLine("1. Feed {0}.                                 |", newPanther.Name);
                    Console.WriteLine("2. Give {0} some water.                      |", newPanther.Name);
                    Console.WriteLine("3. Check {0}'s health.                       |", newPanther.Name);
                    Console.WriteLine("4. Take {0} to the bathroom                  |", newPanther.Name);
                    Console.WriteLine("5. Train with {0}                            |", newPanther.Name);
                    Console.WriteLine("6. Retire {0}                                |", newPanther.Name);
                    Console.WriteLine("\n--------------------------------------------------");
                    Console.WriteLine("XXXXXXXX~~~|XXXXXXXXXXXXXXXXXXXXXXXXXX|~~~XXXXXXXX");
                    Console.WriteLine("--------------------------------------------------\n");
                    
                    
                                        
                    menuSelect = Convert.ToInt32(Console.ReadLine());

                    if (menuSelect == 1)
                    {
                        newPanther.PantherHunger();

                    }
                   else if (menuSelect == 2)
                    {
                        newPanther.PantherThirst();

                    }
                    else if (menuSelect == 3)
                    {
                        newPanther.PantherHealth();

                    }
                    else if (menuSelect == 4)
                    {
                        newPanther.PantherBathroom();

                    }
                    else if (menuSelect == 5)
                    {
                        newPanther.PantherTrain();

                    }
                    else
                    {
                        continue;

                    }

                                       
                }
                while (menuSelect != 6);
            }




        }


    }
}


