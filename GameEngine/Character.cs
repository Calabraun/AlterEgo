using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Character 
    {
        public int CurrentHealth { get; set;}
        public int CurrentDefense { get; set; }
        public int CurrentPower { get; set; }
        public int MaxHealth { get; set; }
        public int MaxDefense { get; set; }
        public int MaxPower { get; set; }
        public bool IsAlive { get; set; }
    }
}
