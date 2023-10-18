using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;

namespace BirdSellingAPI._3._Repository.Repository
{
    public interface IOrderRepository : IRepositoryBase<OrderEntity>
    {

    }

    public class OrderRepository : RepositoryBase<OrderEntity>, IOrderRepository
    {

    }
}
