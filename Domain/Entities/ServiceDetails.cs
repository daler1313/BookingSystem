using Domain.Entity;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ServiceDetails: BaseEntity
    {
        public string DetailName { get; set; }
        public string DetailValue { get; set; }
        public Status status { get; set; }
        public Service Services { get; set; }
        public int ServiceId { get; set; }
    }
}
