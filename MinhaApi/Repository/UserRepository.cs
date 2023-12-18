using MinhaApi.Contracts.Repository;
using MinhaApi.Entity;
using MinhaApi.Infrastructure;
using Dapper;
using MinhaApi.DTO;

namespace MinhaApi.Repository
{
    public class UserRepository : Connection, IUserRepository
    {
        public async Task Add(UserDTO user)
        {
            string sql = @"
                INSERT INTO user (Document, Telephone1, Telephone2, Name, LastName, Email, PasswordHash, Type, CNH, Photo)
                            VALUE (@Document, @Telephone1, @Telephone2, @Name, @LastName, @Email, @PasswordHash, @Type, @CNH, @Photo)
            ";
            await Execute(sql, user);
        }

        public async Task Delete(int id)
        {
            string sql = "DELETE FROM USER WHERE Id = @id";
            await Execute(sql, new { id });
        }

        public Task<IEnumerable<UserDTO>> Get()
        {
            string sql = "SELECT * FROM USER";
            return GetConnection().QueryAsync<UserDTO>(sql);
        }

        public async Task<UserEntity> GetById(int id)
        {
            string sql = "SELECT * FROM USER WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<UserEntity>(sql, new { id });
        }

        public async Task Update(UserEntity user)
        {
            string sql = @"
                UPDATE USER 
                   SET Document = @LicensePlate, 
                       Telephone1 = @Name, 
                       Telephone2 = @Year,
                       Name = @Capacity,
                       LastName = @LastName,
                       Email = @Email,
                       PasswordHash = @PasswordHash,
                       Type = @Type,
                       CNH = @CNH,
                       Photo - @Photo
                 WHERE Id = @Id
            ";
            await Execute(sql, user);
        }

        public async Task<UserTokenDTO> LogIn(LoginUserDTO user)
        {
            string sql = "SELECT * FROM User WHERE Email = @Email AND PasswordHash = @PasswordHash";
            UserEntity userLogin = await GetConnection().QueryFirstAsync<UserEntity>(sql, user);
            return new UserTokenDTO
            {
                Token = Authentication.GenerateToken(userLogin)
            };
        }
    }
}
