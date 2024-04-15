using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ServiceDetails: BaseEntity
    {
        public int BookingNumber {  get; set; }
        public DateTime BookingTime { get; set; }
        public DateTime ShceduleTime { get; set; }
        public string BookedPlaceName { get; set; }
        public Status Status { get; set; }
        public User Users { get; set; }
        public int UserId { get; set; }
        public Service Services { get; set; }
        public int ServiceId { get; set; }

    }
}
