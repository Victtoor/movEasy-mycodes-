using Dapper;
using MinhaApi.Contracts.Repository;
using MinhaApi.Entity;
using MinhaApi.Infrastructure;

namespace MinhaApi.Repository
{
    public class StateRepository : Connection, IStateRepository
    {
        Task<IEnumerable<StateEntity>> IStateRepository.Get()
        {
            string sql = "SELECT * FROM STATE";
            return GetConnection().QueryAsync<StateEntity>(sql);
        }
    }
}
