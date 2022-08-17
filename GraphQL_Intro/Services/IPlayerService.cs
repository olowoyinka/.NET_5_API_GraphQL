using GraphQL_Intro.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphQL_Intro.Services
{
    public interface IPlayerService
    {
        Task<Player> CreatePlayerAsync(Player player);
        Task<int> UpdatePlayerAsync(Player player);
        Task<int> DeletePlayerAsync(Player player);
        Task<Player> GetPlayerAsync(int id);
        Task<IEnumerable<Player>> GetAllPlayersAsync();
    }
}