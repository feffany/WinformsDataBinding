using System.Collections.Generic;
using System.ComponentModel;

namespace InventoryManagerData
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Player> Players { get; set; }

        public List<Item> Items { get; set; }

        public World()
        {
            Players = new List<Player>();
            Items = new List<Item>();
        }
    }
}
