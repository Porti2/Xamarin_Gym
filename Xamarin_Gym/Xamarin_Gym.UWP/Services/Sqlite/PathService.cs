using System.IO;
using Windows.Storage;
using Xamarin.Forms;
using Xamarin_Gym.Services.Sqlite;
using Xamarin_Gym.UWP.Services.Sqlite;

[assembly: Dependency(typeof(PathService))]
namespace Xamarin_Gym.UWP.Services.Sqlite
{
    public class PathService : IPathService
    {
        public string GetDatabasePath()
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, "DBGym.db3");
        }
    }
}
