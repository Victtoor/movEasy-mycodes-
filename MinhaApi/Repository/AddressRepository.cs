using Dapper;
using MinhaApi.Contracts.Repository;
using MinhaApi.DTO;
using MinhaApi.Entity;
using MinhaApi.Infrastructure;

namespace MinhaApi.Repository
{
    public class AddressRepository : Connection, IAddressRepository
    {
        public async Task Add(AddressDTO address)
        {
            throw new NotImplementedException();
            //Metodo ainda não funcional
            //public async Task Create(AddressDTO address)
            //{
            //    string sql = @"INSERT INTO address (Street, PostalCode, Number, Address2, District_id)
            //                        VALUE (@street, @postalCode, @number, @address2, @district_Id)";
            //    await Execute(sql, address);
            //}
        }

        public async Task Delete(int id)
        {
            string sql = "DELETE FROM ADDRESS WHERE Id = @id";
            await Execute(sql, new { id });
        }

        public Task<IEnumerable<AddressDTO>> Get()
        {
            string sql = "SELECT * FROM ADDRESS";
            return GetConnection().QueryAsync<AddressDTO>(sql);
        }

        public async Task<AddressEntity> GetById(int id)
        {
            string sql = "SELECT * FROM ADDRESS WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<AddressEntity>(sql, new { id });
        }

        public async Task Update(AddressEntity address)
        {
            throw new NotImplementedException();
            //Metodo ainda não funcional
            //string sql = @"UPDATE address SET Street = @street,
            //                                  PostalCode = @postalCode,
            //                                  Number = @number,
            //                                  Address2 = @address2,
            //                                  District_Id = @district_id
            //             ";
            //await Execute(sql, address);
        }
    }
}
