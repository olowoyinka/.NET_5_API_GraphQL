using GraphQL_Intro.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphQL_Intro.Services
{
    public interface IPositionService
    {
        Task<IEnumerable<Position>> GetAllPositionsAsync();
    }
}