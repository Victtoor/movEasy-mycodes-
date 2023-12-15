using MinhaApi.DTO;
using MinhaApi.Entity;

namespace MinhaApi.Contracts.Repository
{
    public interface IAddressRepository
    {
        Task Add(AddressDTO vehicle);
        Task Update(AddressEntity vehicle);
        Task Delete(int id);
        Task<AddressEntity> GetById(int id);
        Task<IEnumerable<AddressDTO>> Get();
    }
}
