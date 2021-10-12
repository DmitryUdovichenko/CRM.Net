using AutoMapper;
using CRM.BL.DTO;
using CRM.DA.Entities;
using CRM.PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.PL
{
    public class AutoMapping : AutoMapper.Profile
    {
        public AutoMapping()
        {
            CreateMap<Project, ProjectDTO>().ReverseMap();
            CreateMap<ProjectDTO, ProjectViewModel>().ReverseMap();

            CreateMap<Person, PersonDTO>().ReverseMap();
            CreateMap<PersonDTO, PersonViewModel>().ReverseMap();

            CreateMap<Stage, StageDTO>().ReverseMap();
            CreateMap<StageDTO, StageViewModel>().ReverseMap();
        }
    }
}
