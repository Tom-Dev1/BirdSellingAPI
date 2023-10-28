﻿using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Role;

namespace BirdSellingAPI._2._Service.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRepositoryBase<RoleEntity> _roleRepository;
        private readonly IMapper _mapper;

        public RoleService(IRepositoryBase<RoleEntity> repositoryBase, IMapper mapper)
        {
            _roleRepository = repositoryBase;
            _mapper = mapper;
        }

        //Create
        public ResponseModel CreateRole(RequestRoleModel entity)
        {
            var roleEntity = _mapper.Map<RoleEntity>(entity);
            _roleRepository.Create(roleEntity);
            return new ResponseModel
            {
                Data = roleEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }

        //GetID
        public ResponseModel GetRoleID(string id)
        {
            var roleEntity = _roleRepository.GetSingle(x => x.Id.Equals(id));
            var responseRoleModel = _mapper.Map<ResponseRoleModel>(roleEntity);
            return new ResponseModel
            {
                Data = roleEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }

        //Update
        public ResponseModel UpdateRole(string id, RequestRoleModel requestRoleModel)
        {
            var roleEntity = _roleRepository.GetSingle(x => id.Equals(x.Id));
            if (roleEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _mapper.Map(requestRoleModel, roleEntity);
            _roleRepository.Update(roleEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };

        }

        //Delete bY ID
        public ResponseModel DeleteRole(string id)
        {
            var roleEntity = _roleRepository.GetSingle(x => x.Id.Equals(id));
            if (roleEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _roleRepository.Delete(roleEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
