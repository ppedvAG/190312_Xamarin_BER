using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationMitMasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MD_Root : MasterDetailPage
    {
        public MD_Root()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as PageMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = item.WithNavigation ? new NavigationPage(page) : page;
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}