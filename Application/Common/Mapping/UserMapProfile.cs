using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mapping
{
    internal class UserMapProfile : Profile
    {
        public UserMapProfile()
        {
            CreateMap<CreateUserRequest, ServiceBooking>();
            CreateMap<ServiceBooking, SingleUserResponse>();
        }
    }
}
