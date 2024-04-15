﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class User: BaseEntity
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmaiAddress{ get; set; }
        public virtual ICollection<ServiceBooking> ServiceDetails { get; set; } 
    }
}
