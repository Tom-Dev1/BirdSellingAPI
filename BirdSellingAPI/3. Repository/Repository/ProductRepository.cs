using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;

namespace BirdSellingAPI._3._Repository.Repository
{
    public interface IProductRepository : IRepositoryBase<ProductEntity>
    {

    }
    public class ProductRepository : RepositoryBase<ProductEntity>, IProductRepository
    {
    }
}
