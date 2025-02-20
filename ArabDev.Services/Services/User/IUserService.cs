using ArabDev.Services.Services.User.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Services.Services.User
{
    public interface IUserService
    {
        Task<UserDetailsDto> GetUserByIdAsync(int? UserId);

        Task<IReadOnlyList<UserDetailsDto>> GetAllUserAsync();


       
    }
}
