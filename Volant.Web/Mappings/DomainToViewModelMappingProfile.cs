using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Volant.Model;
using Volant.Web.ViewModel;

namespace Volant.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<Project, ProjectViewModel>();            
        }
    }
}