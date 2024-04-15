using Domain.Entity;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ServiceBookingService : IBaseService<ServiceBooking>
    {
        private readonly IBaseRepository<ServiceBooking> _serviceBookingRepository;

        public ServiceBookingService(IBaseRepository<ServiceBooking> serviceBookingRepository)
        {
            _serviceBookingRepository = serviceBookingRepository;
        }

        public async Task<ServiceBooking> CreateAsync(ServiceBooking serviceBooking, CancellationToken token = default)
        {
            return await _serviceBookingRepository.CreateAsync(serviceBooking, token);
        }

        public async Task<bool> DeleteAsync(ServiceBooking serviceBooking, CancellationToken token = default)
        {
            return await _serviceBookingRepository.DeleteAsync(serviceBooking, token);
        }

        public async Task<IEnumerable<ServiceBooking>> GetAllAsync(CancellationToken token = default)
        {
            return await _serviceBookingRepository.GetAllAsync(token);
        }

        public async Task<ServiceBooking> GetAsync(int  Id, CancellationToken token = default)
        {
            return await _serviceBookingRepository.GetAsync(Id, token);
        }

        public async Task<bool> UpdateAsync(ServiceBooking serviceBooking, CancellationToken token = default)
        {
            var existingBuilding = await GetAsync(serviceBooking.Id);

            if (existingBuilding is null)
            {
                return false;
            }

            existingBuilding.BookingNumber = serviceBooking.BookingNumber;
            existingBuilding.BookingTime = serviceBooking.BookingTime;
            existingBuilding.ShceduleTime = serviceBooking.ShceduleTime;
            existingBuilding.BookedPlaceName = serviceBooking.BookedPlaceName;
            existingBuilding.Status = serviceBooking.Status;
           


            return await _serviceBookingRepository.UpdateAsync(existingBuilding, token);
        }
    }
}
