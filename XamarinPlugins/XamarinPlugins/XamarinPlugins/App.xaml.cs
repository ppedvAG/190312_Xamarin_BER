using SQLite;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinPlugins
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPageRoot();
        }

        public SQLiteAsyncConnection Connection { get; set; }

        protected override void OnStart()
        {
            var fullPath = Path.Combine(FileSystem.AppDataDirectory, "db.sqlite");
            Connection = new SQLiteAsyncConnection(fullPath);

            Connection.CreateTableAsync<LogItem>(); // Wenn die Tabelle bereits existiert, passiert nichts !
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
