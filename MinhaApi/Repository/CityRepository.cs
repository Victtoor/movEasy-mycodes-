using Dapper;
using MinhaApi.Contracts.Repository;
using MinhaApi.Entity;
using MinhaApi.Infrastructure;

namespace MinhaApi.Repository
{
    public class CityRepository : Connection, ICityRepository
    {
        Task<IEnumerable<CityEntity>> ICityRepository.Get()
        {
            string sql = "SELECT * FROM CITY";
            return GetConnection().QueryAsync<CityEntity>(sql);
        }
    }
}
