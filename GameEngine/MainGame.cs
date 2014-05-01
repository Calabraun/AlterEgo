using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class MainGame
    {

        public GameState CurrentGameState;
        public Player CurrentPlayerState;

        public MainGame()
        {
            CurrentGameState = new GameState();
            CurrentPlayerState = new Player();
        }
    }
}
