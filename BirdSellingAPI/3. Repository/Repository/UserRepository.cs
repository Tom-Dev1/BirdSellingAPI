using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;

namespace BirdSellingAPI._3._Repository.Repository
{
    public interface IUserRepository : IRepositoryBase<UserEntity>
    {

    }

    public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
    {

    }
}
