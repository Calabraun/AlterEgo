using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace GameEngine
{
    [Serializable()]
    public class Item
    {
        [System.Xml.Serialization.XmlElement("Name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlElement("DestroyOnUse")]
        public bool DestroyOnUse { get; set; }

        [System.Xml.Serialization.XmlElement("Power")]
        public string Power { get; set; }
    }

    [Serializable()]
    [System.Xml.Serialization.XmlRoot("ItemCollection")]
    public class ItemCollection
    {
        [XmlArray("AllItems")]
        [XmlArrayItem("Item", typeof(Item))]
        public Item[] AvailableItems { get; set; }
    }
}
