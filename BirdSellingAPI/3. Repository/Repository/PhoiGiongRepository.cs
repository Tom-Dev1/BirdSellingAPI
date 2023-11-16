using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;

namespace BirdSellingAPI._3._Repository.Repository
{
    public interface IPhoiGiongRepository : IRepositoryBase<PhoiGiongEntity>
    {
        public bool CreatePhoiGiong (ProductEntity productEntity, PhoiGiongEntity phoiGiongEntity);
    }

    public class PhoiGiongRepository : RepositoryBase<PhoiGiongEntity>, IPhoiGiongRepository
    {
        private readonly BirdFarmContext _context;
        public PhoiGiongRepository()
        {
            _context = new BirdFarmContext();
        }
        public bool CreatePhoiGiong(ProductEntity productEntity, PhoiGiongEntity phoiGiongEntity)
        {
            var myTransaction = _context.Database.BeginTransaction();
            try
            {
                _context.productEntities.Add(productEntity);
                _context.phoiGiongEntities.Add(phoiGiongEntity);
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
