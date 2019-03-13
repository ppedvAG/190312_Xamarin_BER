using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationMitMasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MD_RootMaster : ContentPage
    {
        public ListView ListView;

        public MD_RootMaster()
        {
            InitializeComponent();

            BindingContext = new MD_RootMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MD_RootMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<PageMenuItem> MenuItems { get; set; }
            
            public MD_RootMasterViewModel()
            {
                MenuItems = new ObservableCollection<PageMenuItem>(new[]
                {
                    new PageMenuItem(typeof(Tabs)) { Id = 0, Title = "Tabs" },
                    new PageMenuItem(typeof(FirstPage),true) { Id = 1, Title = "NavigationPage" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}