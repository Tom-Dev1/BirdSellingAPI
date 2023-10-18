using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;

namespace BirdSellingAPI._3._Repository.Repository
{
    public interface IBirdCategoryRepository : IRepositoryBase<BirdCategoryEntity>
    {

    }

    public class BirdCategoryRepository : RepositoryBase<BirdCategoryEntity>, IBirdCategoryRepository
    {

    }
}
