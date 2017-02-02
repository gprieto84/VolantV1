using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Volant.Model;
using Volant.Web.ViewModel;

namespace Volant.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<Project, ProjectViewModel>()
                    .ForMember(g => g.name, map => map.MapFrom(vm => vm.name))
                    .ForMember(g => g.description, map => map.MapFrom(vm => vm.description))
                    .ForMember(g => g.startDate, map => map.MapFrom(vm => vm.startDate))
                    .ForMember(g => g.endDate, map => map.MapFrom(vm => vm.endDate))
                    .ForMember(g => g.progress, map => map.MapFrom(vm => vm.progress))
                    .ForMember(g => g.customerId, map => map.MapFrom(vm => vm.customerId))
                    .ForMember(g => g.customerName, map => map.MapFrom(vm => vm.customer.name))
                    .ForMember(g => g.countOfJobs, map => map.MapFrom(vm => vm.Jobs.Count))
                    .ForMember(g => g.projectStatusName, map => map.MapFrom(vm => vm.projectStatus.name));

            CreateMap<Job, JobViewModel>()
                 .ForMember(g => g.jobName, map => map.MapFrom(vm => vm.jobName))        
                 .ForMember(g => g.startDate, map => map.MapFrom(vm => vm.startDate))
                 .ForMember(g => g.endDate, map => map.MapFrom(vm => vm.endDate))
                 .ForMember(g => g.jobIdentifier, map => map.MapFrom(vm => vm.jobIdentifier))
                 .ForMember(g => g.jobStatusName, map => map.MapFrom(vm => vm.jobStatus.name))
                 .ForMember(g => g.jobTypeName, map => map.MapFrom(vm => vm.jobType.name))
                 .ForMember(g => g.projectName, map => map.MapFrom(vm => vm.project.name))
                 .ForMember(g => g.priority, map => map.MapFrom(vm => vm.priority));

            CreateMap<Project, ProjectFormViewModel>()
                    .ForMember(g => g.name, map => map.MapFrom(vm => vm.name))
                    .ForMember(g => g.description, map => map.MapFrom(vm => vm.description))
                    .ForMember(g => g.startDate, map => map.MapFrom(vm => vm.startDate))
                    .ForMember(g => g.endDate, map => map.MapFrom(vm => vm.endDate))
                    .ForMember(g => g.progress, map => map.MapFrom(vm => vm.progress))
                    .ForMember(g => g.customerId, map => map.MapFrom(vm => vm.customerId))
                    .ForMember(g => g.projectStatusId, map => map.MapFrom(vm => vm.projectStatusId));

            CreateMap<JobMaterial, JobMaterialViewModel>()
               .ForMember(g => g.jobMaterialId, map => map.MapFrom(vm => vm.jobMaterialId))
               .ForMember(g => g.jobId, map => map.MapFrom(vm => vm.jobId))
               .ForMember(g => g.materialId, map => map.MapFrom(vm => vm.materialId))
               .ForMember(g => g.jobName, map => map.MapFrom(vm => vm.job.jobName))
               .ForMember(g => g.materialName, map => map.MapFrom(vm => vm.material.description))
               .ForMember(g => g.quantity, map => map.MapFrom(vm => vm.quantity));


        }
    }
}