using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.IRepository.Interfaces;
using Tracker.Services.IServices;
using Tracker.Services.Models;

namespace Tracker.Services.Services
{
    public class UserService : IUserService
    {
        private IUserRepository UserRepo;
        public UserService(IUserRepository userRepo)
        {
            UserRepo = userRepo;
        }

        public void AddUser(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public UserDTO FindUser(string username, string password)
        {
            var user = UserRepo.FindUser(username, password);
            if (user != null)
            {
                return new UserDTO()
                {
                    Username = user.Username,
                    Email = user.Email,
                    Id_User = user.Id_User
                };
            }
            else return null;
        }
    }
}
