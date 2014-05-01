using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace GameEngine
{
    public class StateController
    {
        #region Example of Generic with no Constraint
        //public void TestForAllTypes<T>(T test)
        //{
        //    var test2 = test;
        //}
        #endregion Example of Generic with no Constraint

        private GameState alterEgoGameState;
        private Player alterEgoPlayer;

        #region Setup
        /// <summary>
        /// Instantiate and initialize the game
        /// </summary>
        public void InitializeGameState()
        {
            alterEgoGameState = new GameState();
            alterEgoPlayer = new Player(); 
        }
        #endregion Setup

        #region Game and Player States
        public GameState.State GetGameState() 
        {
            return alterEgoGameState.CurrentState;            
        }

        public Player.State GetPlayerState() 
        {
            return alterEgoPlayer.CurrentState;
        }

        public void SetGameState<T>(T gameState) 
        {
          alterEgoGameState.CurrentState = (GameState.State)Enum.Parse(typeof(GameState.State), gameState.ToString());
        }

        public void SetPlayerState<T>(T playerState)
        {
            alterEgoPlayer.CurrentState = (Player.State)Enum.Parse(typeof(Player.State), playerState.ToString());
        }
        #endregion Game and Player States
    }

    class RunGenericTest
    {
        public void RunTest()
        {
            StateController test1 = new StateController();
            var test2 = test1.GetGameState();
            test1.SetGameState(GameState.State.Introduction);

            ItemCollection items = null;
            string path = "Items.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(ItemCollection));
            StreamReader reader = new StreamReader(path);
            items = (ItemCollection)serializer.Deserialize(reader);
            reader.Close();

           
            





            //test1.SetGameState(GameState.State.Introduction);

            //GenericTest<int> test2 = new GenericTest<int>();


            //test1.TestForStrings<string>("Test");
            //test2.TestForInts<int>(25);

    

        }
    }


}
