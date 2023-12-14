using MinhaApi.Contracts.Repository;
using MinhaApi.Entity;
using MinhaApi.Infrastructure;
using Dapper;
using MinhaApi.DTO;

namespace MinhaApi.Repository
{
    public class VehicleRepository : Connection, IVehicleRepository
    {
        public async Task Add(VehicleDTO vehicle)
        {
            string sql = @"
                INSERT INTO vehicle (LicensePlate, Name, Year, Capacity)
                            VALUE (@LicensePlate, @Name, @Year, @Capacity)
            ";
            await Execute(sql, vehicle);
        }

        public async Task Delete(int id)
        {
            string sql = "DELETE FROM VEHICLE WHERE Id = @id";
            await Execute(sql, new { id });
        }

        public Task<IEnumerable<VehicleEntity>> Get()
        {      
            string sql = "SELECT * FROM VEHICLE";
            return GetConnection().QueryAsync<VehicleEntity>(sql);            
        }

        public async Task<VehicleEntity> GetById(int id)
        {
            string sql = "SELECT * FROM VEHICLE WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<VehicleEntity>(sql, new { id });
        }

        public async Task Update(VehicleEntity vehicle)
        {
            string sql = @"
                UPDATE VEHICLE 
                   SET LicensePlate = @LicensePlate, 
                       Name = @Name, 
                       Year = @Year,
                       Capacity = @Capacity
                 WHERE Id = @Id
            ";
            await Execute(sql, vehicle);
        }
    }
}
