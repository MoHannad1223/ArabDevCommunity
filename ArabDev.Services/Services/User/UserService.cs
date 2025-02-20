using ArabDev.Data.DataOrEntities;
using ArabDev.Repository.Interfaces;
using ArabDev.Services.Services.User.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Services.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IReadOnlyList<UserDetailsDto>> GetAllUserAsync()
        {
           var users= await _unitOfWork.Repository<ArabDev.Data.DataOrEntities.User,int>().GetAllAsNoTrackingAsync();
            var mappedUsers = users.Select(x => new UserDetailsDto
            {
                Id = x.Id,
                UserName = x.UserName,
                Email = x.Email,
                Job=x.Job,
                CreatAt=x.CreateAt
            }).ToList();
            return mappedUsers;
        }

        public async Task<UserDetailsDto> GetUserByIdAsync(int? UserId)
        {
            if (UserId is null)
                throw new Exception("Id Is NUll");
            var user=await _unitOfWork.Repository<ArabDev.Data.DataOrEntities.User,int>().GetByIdAsync(UserId.Value);
            if (user is null)
                throw new Exception("User Not eXIST");
            var mappedUser = new UserDetailsDto { 
            Id = user.Id,
            UserName = user.UserName,
            Email = user.Email,
            Job = user.Job,
            CreatAt = user.CreateAt
            };
            return mappedUser;
        }
    }
}
