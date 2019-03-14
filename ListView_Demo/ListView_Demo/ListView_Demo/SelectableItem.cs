using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ListView_Demo
{
    public class SelectableItem : INotifyPropertyChanged
    {
        public string Item { get; set; }
        private bool isSelected;
        public bool IsSelected
        {
            get => isSelected;
            set
            {
                isSelected = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsSelected)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
