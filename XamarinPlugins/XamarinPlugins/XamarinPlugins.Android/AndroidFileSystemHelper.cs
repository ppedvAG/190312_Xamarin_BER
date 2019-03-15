using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
[assembly: Xamarin.Forms.Dependency(typeof(XamarinPlugins.Droid.AndroidFileSystemHelper))]
namespace XamarinPlugins.Droid
{
    public class AndroidFileSystemHelper : IFileSystemHelper
    {
        public string LoadText(string filename)
        {
            // /data/data/com.firmenname.appname/files
            var fullpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), filename);
            return File.ReadAllText(fullpath);
        }

        public void SaveText(string filename, string content)
        {
            // /data/data/com.firmenname.appname/files
            var fullpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),filename);
            File.WriteAllText(fullpath, content);
        }
    }
}