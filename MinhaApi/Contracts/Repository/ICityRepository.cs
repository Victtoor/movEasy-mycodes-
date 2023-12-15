using MinhaApi.Entity;

namespace MinhaApi.Contracts.Repository
{
    public interface ICityRepository
    {
        Task<IEnumerable<CityEntity>> Get();

    }
}
