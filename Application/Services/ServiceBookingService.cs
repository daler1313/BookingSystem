using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ServiceBookingService : IBaseService<ServiceBooking>
    {
        private readonly IBaseRepository<ServiceBooking> _buildingRepository;

        public ServiceBookingService(IBaseRepository<ServiceBooking> buildingRepository)
        {
            _buildingRepository = buildingRepository;
        }

        public async Task<ServiceBooking> CreateAsync(ServiceBooking building, CancellationToken token = default)
        {
            return await _buildingRepository.CreateAsync(building, token);
        }

        public async Task<bool> DeleteAsync(ServiceBooking building, CancellationToken token = default)
        {
            return await _buildingRepository.DeleteAsync(building, token);
        }

        public async Task<IEnumerable<ServiceBooking>> GetAllAsync(CancellationToken token = default)
        {
            return await _buildingRepository.GetAllAsync(token);
        }

        public async Task<ServiceBooking> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _buildingRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(ServiceBooking building, CancellationToken token = default)
        {
            var existingBuilding = await GetAsync(building.Id);

            if (existingBuilding is null)
            {
                return false;
            }

            existingBuilding.Name = building.Name;
            existingBuilding.Address = building.Address;
            existingBuilding.CeilingHeight = building.CeilingHeight;
            existingBuilding.BuildingClass = building.BuildingClass;
            existingBuilding.EntrancesCount = building.EntrancesCount;
            existingBuilding.Material = building.Material;

            return await _buildingRepository.UpdateAsync(existingBuilding, token);
        }
    }
}
