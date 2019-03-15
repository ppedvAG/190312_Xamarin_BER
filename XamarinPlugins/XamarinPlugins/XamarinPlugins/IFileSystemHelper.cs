using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPlugins
{
    public interface IFileSystemHelper
    {
        void SaveText(string filename, string content);
        string LoadText(string filename);
    }
}
