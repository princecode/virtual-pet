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
        //  Waste ("               " )
        //  Play ("              ")
        private string Name { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Health { get; set; }
        public bool Bathroom { get; set; }
        public bool Play { get; set; }
        
        //Pet Methods
        //Tick method
    }
}
