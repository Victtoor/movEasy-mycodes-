using MinhaApi.Contracts.Repository;
using MinhaApi.Entity;
using MinhaApi.Infrastructure;
using Dapper;

namespace MinhaApi.Repository
{
    public class DistrictRepository : Connection, IDistrictRepository
    {
        Task<IEnumerable<DistrictEntity>> IDistrictRepository.Get()
        {
            string sql = "SELECT * FROM DISTRICT";
            return GetConnection().QueryAsync<DistrictEntity>(sql);
        }
    }
}
