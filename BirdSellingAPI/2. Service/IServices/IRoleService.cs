using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.Role;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IRoleService
    {
        public ResponseModel CreateRole(RequestRoleModel entity);
        public ResponseModel GetAll();
        public ResponseModel GetRoleID(string id);
        public ResponseModel UpdateRole(string id, RequestRoleModel requestRoleModel);
        public ResponseModel DeleteRole(string id);

    }
}
