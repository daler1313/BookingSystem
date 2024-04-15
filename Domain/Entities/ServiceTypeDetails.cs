using Domain.Entity;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ServiceTypeDetails: BaseEntity
    {
        public string DetailName { get; set; }
        public string DetailType { get; set; }
        public Status Status { get; set; }
        public ServiceType ServiceTypes { get; set; }
        public int ServiceTypeId { get; set; }


    }
}
