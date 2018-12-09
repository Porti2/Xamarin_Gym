using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Gym.Models;

namespace Xamarin_Gym.Services.Sqlite
{
    public interface ISqliteService
    {
        Task<IList<Cliente>> GetAllAsync();
        Task Insert(Cliente item);
        Task RemoveAsync(Cliente item);
    }
}
