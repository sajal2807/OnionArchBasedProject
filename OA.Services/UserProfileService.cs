using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IRepository<UserProfile> userProfileRepository;
        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

        public UserProfile GetUserProfile(long id)
        {
            return this.userProfileRepository.Get(id);
        }
    }
}
