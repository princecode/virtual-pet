using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Pet
    {
        //Properties
        //  Name
        //  Hunger (and how feeding works)
        //  Thirst (and how watering works)
        //  Health ("              ")
        //  Bathroom ("               " )
        //  Train ("              ")

        public string Name { get; set; }

        private int hunger;
        private int maxHunger = 10;
        private int minHunger = 1;
        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
                if (hunger > maxHunger) ;
                {
                    hunger = maxHunger;
                }
                if (hunger < minHunger) ;
                {

                    hunger = minHunger;
                }


            }


        }

       


        public int Thirst { get; set; }

        

        public int Health { get; set; }
        public int Bathroom { get; set; }
        public int Train { get; set; }

        //Pet Methods
        public Pet()
        {
            //TODO
            Hunger = 5;
            Thirst = 5;
            Health = 7;
            Bathroom = 5;
            Train = 2;

        }

        //name method
        public string PantherName()
        {
            return Name = Console.ReadLine();
        }
        //---------------------


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("\n--------------------------------------------------");
            sb.AppendFormat("XXXXXX~~~| Panther Totem: {0} Stats |~~~XXXXXX\n", Name);
            sb.AppendLine("--------------------------------------------------\n");
            sb.AppendFormat("Hunger: {0}                                     |\n", Hunger);
            sb.AppendFormat("Thirst: {0}                                     |\n", Thirst);
            sb.AppendFormat("Health: {0}                                     |\n", Health);
            sb.AppendFormat("Bathroom: {0}                                   |\n", Bathroom);
            sb.AppendFormat("Train: {0}                                      |\n", Train);
            sb.AppendLine("\n--------------------------------------------------");
            sb.AppendLine("XXXXXXXX~~~|XXXXXXXXXXXXXXXXXXXXXXXXXX|~~~XXXXXXXX");
            sb.AppendLine("--------------------------------------------------");

            return sb.ToString();
        }

        //-----------------------------------

        public int PantherHunger()
        {
            //Todo
            if (Hunger >= 10)
            {
                Console.WriteLine("\n" + Name + " is full! Maybe try some training to burn off those calories!");
            }
            else
            {
                Hunger--;
                Thirst -= 1;
                Bathroom += 1;
                                
            }
            return Hunger;
            //Tick()
        }
        // ------------------------
        public int PantherThirst()
        {
            //Todo
            if (Thirst >= 10)
            {
                Console.WriteLine("\n" + Name + " is no thirsty! Maybe try some training!");
            }
            else
            {
                Thirst--;
                Hunger += 1;
                Bathroom += 2;
                
            }
            return Thirst;
            //Tick()
        }
        //----------------------------------
        public int PantherHealth()
        {
            //Todo
            if (Hunger <= 2 || Thirst <= 2 || Health <= 2)            
            {
                Console.WriteLine("\n" + Name + " is very weak! You need to check their vitals and train if you ever want to see battle!");
            }        
            else if (Health >= 9)
            {
                Console.WriteLine("\n" + Name + " is in great shape! The two of you will make great warriors!");
                Health = 10;
            }
                     
            return Health;
            //Tick()
        }
        //----------------------------------
        public int PantherBathroom()
        {
            //Todo
           

            return Bathroom;
        }
        //----------------------------------
        public int PantherTrain()
        {
            //Todo
            return Train;
        }
        //----------------------------------
        //Tick method
        //public void Tick();
        //{
        ////todo
        //continue 
        //}

    }
}
