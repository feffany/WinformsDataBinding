using System.ComponentModel;

namespace InventoryManagerData
{
    public class Item : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }
    }
}
