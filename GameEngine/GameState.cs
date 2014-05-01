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
    public class GameState
    {
        #region Game state Enumerators
        public enum State
        {
            Introduction = 1,
            Exploration = 2,
            Combat = 3,
            GameOver = 4,
            Menu = 5
        }

        public enum RealmType
        {
            HomeWorld = 1,
            AlternateWorld = 2
        }

        public enum LocationType
        {
            Home = 1,
            City = 2,
            Ship = 3,
            Hospital = 4,
            Church = 5,
            Shop = 6,
            Work = 7,
            Land = 8,
            Water = 9
        }
        #endregion Game state Enumerators

        #region Properties
        public RealmType CurrentRealm { get; set; }

        private LocationType location;
        public LocationType Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
                switch (location)
                {
                    case LocationType.Home:
                    case LocationType.Church:
                    case LocationType.Hospital:
                    case LocationType.Ship:
                    case LocationType.Shop:
                    case LocationType.Work:
                    {
                        isInside = true;
                        break;
                    }
                    case LocationType.City:
                    case LocationType.Water:
                    case LocationType.Land:
                    {
                        isInside = false;
                        break;
                    }
                }
            }
        }

        private bool isInside;
        public bool IsInside { get { return isInside; } }

        public State CurrentState { get; set; }

        private ItemCollection availableItems;
        public ItemCollection AvailableItems { get; set; }
        #endregion Properties

        #region Public Methods

        public GameState()
        {
            CurrentState = State.Introduction;
            Location = LocationType.Home;
            CurrentRealm = RealmType.HomeWorld;
            PopulateListofItems();
        }
        #endregion Public Methods

        #region Private Methods
        private void PopulateListofItems()
        {
            string path = "Items.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(ItemCollection));
            StreamReader reader = new StreamReader(path);
            availableItems = (ItemCollection)serializer.Deserialize(reader);
            reader.Close();
        }
        #endregion Private Methods
    }
}
