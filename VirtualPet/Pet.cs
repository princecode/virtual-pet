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
        public int Hunger { get; set; }
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
        public bool PantherPlay()
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
