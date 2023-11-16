using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;

namespace BirdSellingAPI._3._Repository.Repository
{
    public interface IOrderRepository : IRepositoryBase<OrderEntity>
    {
        public bool CreateOrder(OrderEntity order, List<CartEntity> carts);
    }

    public class OrderRepository : RepositoryBase<OrderEntity>, IOrderRepository
    {
        private readonly BirdFarmContext _context;

        public OrderRepository() 
        {
            _context = new BirdFarmContext();
        }
        public bool CreateOrder(OrderEntity order, List<CartEntity> carts)
        {
            var myTransaction = _context.Database.BeginTransaction();
            try
            {
                _context.orderEntities.Add(order);
                foreach (var cart in carts)
                {
                    _context.cartEntities.Update(cart);
                }
                _context.SaveChanges();
                myTransaction.Commit();
                return true;
            }
            catch
            {
                myTransaction.Rollback();
                return false;
            }
        }
    }
}
