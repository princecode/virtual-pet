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
                if (hunger < maxHunger);
                {
                    hunger = 0;
                }
                if (hunger > minHunger);
                {

                    hunger = minHunger;
                }
                

            }
      

            }


    
        public int Thirst { get; set; }
        public int Health { get; set; }
        public bool Bathroom { get; set; }
        public bool Train { get; set; }
        
        //Pet Methods
        public Pet()
        {
            //TODO
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
            sb.AppendFormat("XXXXXXXX~~~| Panther Totem: {0} Stats |~~~XXXXXXXX\n", Name);
            sb.AppendLine("--------------------------------------------------\n");
            sb.AppendFormat("Hunger: {0}" + "       |\n", Hunger);
            sb.AppendFormat("Thirst: {0}        |\n", Thirst);
            sb.AppendFormat("Health: {0}     |\n", Health);
            sb.AppendFormat("Bathroom: {0}   |\n", Bathroom);
            sb.AppendFormat("Train: {0}       |\n", Train);
            sb.AppendLine("\n--------------------------------------------------");
            sb.AppendLine("XXXXXXXX~~~|XXXXXXXXXXXXXXXXXXXXXXXXXX|~~~XXXXXXXX");
            sb.AppendLine("--------------------------------------------------\n");

            return sb.ToString();
        }

        //-----------------------------------

        public int PantherHunger()
        {
            //Todo
            return Hunger;
        }
        // ------------------------
        public int PantherThirst()
        {
            //Todo
            return Thirst;
        }
        //----------------------------------
        public int PantherHealth()
        {
            //Todo
            return Health;
        }
        //----------------------------------
        public bool PantherBathroom()
        {
            //Todo
            return Bathroom;
        }
        //----------------------------------
        public bool PantherTrain()
        {
            //Todo
            return Train;
        }
        //----------------------------------
        //Tick method
        //public void Tick();
        //{
        ////todo
        
        //}

    }
}
