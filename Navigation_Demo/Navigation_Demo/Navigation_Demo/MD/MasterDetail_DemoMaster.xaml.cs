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

namespace Navigation_Demo.MD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail_DemoMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetail_DemoMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetail_DemoMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetail_DemoMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetail_DemoMenuItem> MenuItems { get; set; }
            
            public MasterDetail_DemoMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetail_DemoMenuItem>(new[]
                {
                    new MasterDetail_DemoMenuItem(typeof(MasterDetail_DemoDetail)) { Id = 0, Title = "Page 1" },
                    new MasterDetail_DemoMenuItem(typeof(MasterDetail_DemoDetail)) { Id = 1, Title = "Page 2" },
                    new MasterDetail_DemoMenuItem(typeof(MasterDetail_DemoDetail)) { Id = 2, Title = "Page 3" },
                    new MasterDetail_DemoMenuItem(typeof(TabbedPage_Demo)) { Id = 3, Title = "TabbedPage" },
                    new MasterDetail_DemoMenuItem(typeof(MainPage)) { Id = 4, Title = "MainPage" },
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