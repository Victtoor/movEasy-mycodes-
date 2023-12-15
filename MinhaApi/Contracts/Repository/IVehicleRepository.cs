using MinhaApi.DTO;
using MinhaApi.Entity;

namespace MinhaApi.Contracts.Repository
{
    public interface IVehicleRepository
    {
        Task Add(VehicleDTO vehicle);
        Task Update(VehicleEntity vehicle);
        Task Delete(int id);
        Task<VehicleEntity> GetById(int id);
        Task<IEnumerable<VehicleDTO>> Get();
    }
}