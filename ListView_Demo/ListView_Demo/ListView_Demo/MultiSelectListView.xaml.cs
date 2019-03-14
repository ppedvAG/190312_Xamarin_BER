using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView_Demo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MultiSelectListView : ContentView
	{
		public MultiSelectListView ()
		{
			InitializeComponent ();
            this.BindingContext = this;
		}

        // Bindable-Property:
        // WPF-Snippet für DependencyProperty umbauen auf BindableProperty
        // propdp
        // 1) DependencyProperty durch BindableProperty ersetzen
        // 2) Statt "Register" "Create" ausführen
        // 3) Datentypen anpassen + Namen anpassen


        public ObservableCollection<SelectableItem> Data
        {
            get => (ObservableCollection<SelectableItem>)GetValue(DataProperty);
            set
            {
                SetValue(DataProperty, value);
                OnPropertyChanged();
            }
        }
        public static readonly BindableProperty DataProperty =
            BindableProperty.Create(nameof(Data), typeof(ObservableCollection<SelectableItem>), typeof(MultiSelectListView));

        private void ListViewData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (SelectableItem)e.Item;
            item.IsSelected = ! item.IsSelected;
        }

        public List<SelectableItem> SelectedItems
        {
            get => Data.Where(x => x.IsSelected).ToList();
        }
    }
}