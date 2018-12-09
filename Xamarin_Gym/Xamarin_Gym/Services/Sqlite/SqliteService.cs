using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_Gym.Models;

namespace Xamarin_Gym.Services.Sqlite
{
    public class SqliteService : ISqliteService
    {
        private SQLiteAsyncConnection _sqlCon;

        public SqliteService()
        {
            var databasePath = DependencyService.Get<IPathService>().GetDatabasePath();
            _sqlCon = new SQLiteAsyncConnection(databasePath);

            CreateDatabaseAsync();
        }

        public async Task CreateDatabaseAsync()
        {
            await _sqlCon.CreateTableAsync<Cliente>(CreateFlags.None).ConfigureAwait(false);
            //await _sqlCon.CreateTableAsync<Entrenador>(CreateFlags.None).ConfigureAwait(false);
        }
        
        public async Task<IList<Cliente>> GetAllAsync()
        {
            return null; //await _sqlCon.GetAsync<Cliente>();
            
        }
        
        public async Task Insert(Cliente item)
        {

            var existingCliente = await _sqlCon.Table<Cliente>()
                    .Where(x => x.ID == item.ID)
                    .FirstOrDefaultAsync();

            if (existingCliente == null)
            {
                await _sqlCon.InsertAsync(item).ConfigureAwait(false);
            }
        }


        public async Task RemoveAsync(Cliente item)
        {
            await _sqlCon.DeleteAsync(item);
        }
    }
}
