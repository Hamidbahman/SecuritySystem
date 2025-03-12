using System;
using AutoMapper;
using controlpannel.api.Dtos;
using ControlPannel.Domain.Entities;

namespace controlpannel.api.MappingProfiles;

public class AddApplicationRequestDtoToApplicationProfile : Profile 
{
    public AddApplicationRequestDtoToApplicationProfile()
    {
        CreateMap<AddApplicationRequestDto, Aplication>()
            .ForMember(dest=> dest.Id, src => src.Ignore())
            .ForMember(dest => dest.CreateDate, src => src.MapFrom(src => DateTime.UtcNow))
            .ForMember(dest => dest.ModifyDate, src => src.MapFrom(src => DateTime.UtcNow))
            .ForMember(dest => dest.DeleteDate, src => src.MapFrom(src => DateTime.UtcNow))
            .ForMember(dest => dest.ModifyUser, src => src.Ignore())
            .ForMember(dest => dest.DeleteUser, src => src.Ignore())
            .ForMember(dest=> dest.ClientScope, src => src.MapFrom(src => src.ClientScope))
            .ForMember(dest=> dest.ClientSecret, src => src.MapFrom(src => src.ClientSecret))
            .ForMember(dest=> dest.Description, src => src.MapFrom(src => src.Description))
            .ForMember(dest=> dest.IpRange, src => src.MapFrom(src => src.IpRange))
            .ForMember(dest=> dest.LockEnabled, src => src.MapFrom(src => src.LockEnabled))
            .ForMember(dest=> dest.AuthenticateGrantType, src => src.MapFrom(src => src.AuthorizationGrandType))
            .ForMember(dest=> dest.IsAutoApprove, src => src.MapFrom(src => src.IsAutoApprove))
            .ForMember(dest=> dest.Status, src => src.MapFrom(src => src.Status))
            .ForMember(dest=> dest.Scheduled, src => src.MapFrom(src => src.Scheduled))
            .ForMember(dest=> dest.Title, src => src.MapFrom(src => src.Title));
            
    }
}
