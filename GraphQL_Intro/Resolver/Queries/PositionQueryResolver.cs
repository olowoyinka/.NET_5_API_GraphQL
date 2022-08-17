using GraphQL_Intro.Models;
using GraphQL_Intro.Services;
using HotChocolate;
using HotChocolate.Types;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphQL_Intro.Resolver.Queries
{
    [ExtendObjectType("Query")]
    public class PositionQueryResolver
    {
        [GraphQLName("positions")]
        [GraphQLDescription("Positions API")]
        public async Task<IEnumerable<Position>> GetAllPositionsAsync([Service] IPositionService positionService)
        {
            return await positionService.GetAllPositionsAsync();
        }
    }
}