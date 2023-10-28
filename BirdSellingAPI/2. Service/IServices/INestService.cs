using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.Nest;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface INestService
    {
        public ResponseModel CreateNest(RequestNestModel requestNestModel);
        public ResponseModel GetAll();
        public ResponseModel GetSingle(string id);
        public ResponseModel UpdateNest(string id, RequestNestModel requestNestModel);
        public ResponseModel DeleteNest(string id);

    }
}
