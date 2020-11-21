using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using InventoryManagerData;

namespace WinformsDataBindingTutorial.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Filename { get; set; }
        public World World { get; set; }
    }
}
