using System.Collections.Generic;
using System.Threading.Tasks;

using UserAuth.Core.Models.User;

namespace UserAuth.Core.Services
{
    public class UserService
    {
        public async Task<IEnumerable<UserDTO>> GetAllUsers()
        {
            return new List<UserDTO>() { new UserDTO { ID = 1, Name = "UserName" } };   
        }
    }
}