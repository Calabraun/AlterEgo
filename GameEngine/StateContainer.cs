using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class StateContainer
    {
        public enum State
        {
            AlterEgoLight = 1,
            AlterEgoDark = 2,
            Introduction = 3,
            Exploration = 4,
            Combat = 5,
            GameOver = 6
        }
        public State CurrentState { get; set; }
    }
}
