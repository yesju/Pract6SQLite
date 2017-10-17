using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Pract6SQLite.UWP;
using Windows.Storage;

[assembly: Dependency(typeof(ISQLite_UWP))]
namespace Pract6SQLite.UWP
{
    public class ISQLite_UWP :ISQLite
    {
        public string GetLocalFilePath(string Filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, Filename);
        }
    }
}
