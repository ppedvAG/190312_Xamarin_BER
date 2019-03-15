using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPlugins
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LogPage : ContentPage
	{
		public LogPage ()
		{
			InitializeComponent ();
		}
        List<LogItem> log;

        private void SearchBarSuchtext_TextChanged(object sender, TextChangedEventArgs e)
        {
            listViewLog.ItemsSource = log.Where(x => x.Text.ToLower().Contains(e.NewTextValue.ToLower()));
        }

        private async void ListViewLog_Refreshing(object sender, EventArgs e)
        {
            log = await ((App)App.Current).Connection.Table<LogItem>().OrderByDescending(x => x.Date).ToListAsync();
            listViewLog.ItemsSource = log;

            listViewLog.EndRefresh();
        }

        private async void ButtonGetLog_Clicked(object sender, EventArgs e)
        {
            log = await((App)App.Current).Connection.Table<LogItem>().OrderByDescending(x => x.Date).ToListAsync();
            listViewLog.ItemsSource = log;

            listViewLog.EndRefresh();
        }

        private void ListViewLog_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            MessagingCenter.Send(this, "Speak", (e.Item as LogItem).Text);
        }
    }
}