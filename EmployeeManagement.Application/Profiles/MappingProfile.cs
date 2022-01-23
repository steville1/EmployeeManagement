using AutoMapper;
using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           
            CreateMap<Employee, EmployeeDto>().ReverseMap();
           
        }
    }
}
