using System;
using AutoMapper;
using ControlPannel.Domain.Entities;

namespace controlpannel.api.MappingProfiles;

public class AddConfigurationPasswordRequestToConfigurationPasswordProfile : Profile
{
    public AddConfigurationPasswordRequestToConfigurationPasswordProfile()
    {
        CreateMap<AddConfigurationPasswordRequestDto, ConfigurationPassword>()
            .ForMember(dest=> dest.Id, src => src.Ignore())
            .ForMember(dest => dest.CreateDate, src => src.MapFrom(src => DateTime.UtcNow))
            .ForMember(dest => dest.ModifyDate, src => src.MapFrom(src => DateTime.UtcNow))
            .ForMember(dest => dest.DeleteDate, src => src.MapFrom(src => DateTime.UtcNow))
            .ForMember(dest => dest.ModifyUser, src => src.Ignore())
            .ForMember(dest => dest.DeleteUser, src => src.Ignore())
            .ForMember(dest => dest.IsComplex, src => src.MapFrom(src => ));

            
    }
}


