using ArabDev.Data.DataOrEntities;
using ArabDev.Repository.Interfaces;
using ArabDev.Repository.Specification.UserSpecification;
using ArabDev.Services.Services.DTOS;
using ArabDev.Services.Services.Helper;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Services.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork,IMapper mapper) 
        {
            _unitOfWork = unitOfWork;
           _mapper = mapper;
        }

        public async Task<PaginateResultDto<UserDetailsDto>> GetAllUserAsync(UserSpecification input)
        {
            var spec = new UserWithSpecification(input);
            var users = await _unitOfWork.Repository<User, int>().GetAllWithSpecificationAsync(spec);
            var countSpec = new UserWithCountSpecification(input);
            var count = await _unitOfWork.Repository<User, int>().GetcountSpecificationAsync(countSpec);
            var mappedUsers = _mapper.Map<IReadOnlyList<UserDetailsDto>>(users);

            return new PaginateResultDto<UserDetailsDto>(input.PageIndex, input.PageSize,count, mappedUsers);
        }

            public async Task<UserDetailsDto> GetUserByIdAsync(int? UserId)
        {
            if (UserId is null)
                throw new Exception("Id Is NUll");

            var spac=new UserWithSpecification(UserId);
            var user=await _unitOfWork.Repository<ArabDev.Data.DataOrEntities.User,int>().GetWithSpecificationByIdAsync(spac);
            if (user is null)
                throw new Exception("User Not eXIST");
            var mappedUser = _mapper.Map<UserDetailsDto>(user);

            return mappedUser;
        }
    }
}
