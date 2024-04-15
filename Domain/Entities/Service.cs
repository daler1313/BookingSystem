using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Service: BaseEntity
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<ServiceBooking> ServiceBookings { get; set; }
        


    }
}
