using System;
using System.IO;
using Android.OS;
using Xamarin.Forms;
using Xamarin_Gym.Droid.Services.Sqlite;
using Xamarin_Gym.Services.Sqlite;
using Environment = System.Environment;

[assembly: Dependency(typeof(PathService))]
namespace Xamarin_Gym.Droid.Services.Sqlite
{
    public class PathService : IPathService
    {

        public string GetDatabasePath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "DBGym.db3");
        }
    }
}