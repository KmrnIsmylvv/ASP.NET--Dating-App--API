using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;

namespace API.Data
{
    public class LikesRepository : ILikesRepository
    {
        private readonly DataContext _context;
        public LikesRepository(DataContext context)
        {
            _context = context;
        }
        public Task<UserLike> GetUserLike(int sourceUserId, int likedUserId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<LikeDto>> GetUserLikes(string predicate, int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<AppUser> GetUserWithLikes(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
}