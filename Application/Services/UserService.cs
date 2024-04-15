using Domain.Entity;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IBaseService<User>
    {
        private readonly IBaseRepository<User> _UserRepository;

        public UserService(IBaseRepository<User> UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public async Task<User> CreateAsync(User User, CancellationToken token = default)
        {
            return await _UserRepository.CreateAsync(User, token);
        }

        public async Task<bool> DeleteAsync(User User, CancellationToken token = default)
        {
            return await _UserRepository.DeleteAsync(User, token);
        }

        public async Task<IEnumerable<User>> GetAllAsync(CancellationToken token = default)
        {
            return await _UserRepository.GetAllAsync(token);
        }

        public async Task<User> GetAsync(int Id, CancellationToken token = default)
        {
            return await _UserRepository.GetAsync(Id, token);
        }

        public async Task<bool> UpdateAsync(User User, CancellationToken token = default)
        {
            var existingBuilding = await GetAsync(User.Id);

            if (existingBuilding is null)
            {
                return false;
            }

            existingBuilding.Name = User.Name;
            existingBuilding.UserName = User.UserName;
            existingBuilding.PhoneNumber = User.PhoneNumber;
            existingBuilding.EmaiAddress = User.EmaiAddress;

            return await _UserRepository.UpdateAsync(existingBuilding, token);
        }
    }
}
