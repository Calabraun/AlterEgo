using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Player : Character
    {
        public enum State
        {
            AlterEgoLight = 1,
            AlterEgoDark = 2
        }

        public State CurrentState { get; set; }
        private ItemCollection[] inventory;
        public ItemCollection[] Inventory
        {
            get
            {
                if (inventory == null || inventory.Count() == 0)
                    inventory = new ItemCollection[5];
                return inventory;
            }
            set
            {
                inventory = value;
            }
        }

        public Player()
        {
            CurrentState = State.AlterEgoLight;
            MaxDefense = 10;
            MaxHealth = 10;
            MaxDefense = 10;
        }
    }
}
