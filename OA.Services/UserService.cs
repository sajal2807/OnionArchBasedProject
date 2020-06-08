using Microsoft.EntityFrameworkCore.Migrations;
using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;
        private readonly IRepository<UserProfile> userProfileRepository;
        public UserService(IRepository<User> userRepository, IRepository<UserProfile> userProfileRepository)
        {
            this.userRepository = userRepository;
            this.userProfileRepository = userProfileRepository;
        }

        public void DeleteUser(long id)
        {
            UserProfile userProfile = userProfileRepository.Get(id);
            userProfileRepository.remove(userProfile);

            User user = userRepository.Get(id);
            userRepository.remove(user);

        }

        public User GetUser(long id)
        {
            return userRepository.Get(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        public void InsertUser(User user)
        {
            userRepository.insert(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.update(user);
        }
    }
}
