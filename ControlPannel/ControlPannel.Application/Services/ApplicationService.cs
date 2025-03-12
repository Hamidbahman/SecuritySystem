using System;
using ControlPannel.Domain.Entities;
using ControlPannel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using controlpannel.infrastructure.Repositories;
using Microsoft.EntityFrameworkCore.Metadata;
using AutoMapper;

namespace controlpannel.application.Services;

public class ApplicationService
{
    private readonly ApplicationRepository _appRepo;
    private readonly IMapper _mapper;
    public ApplicationService(ApplicationRepository appRepo, IMapper mapper)
    {
        _appRepo = appRepo;
        _mapper = mapper;
    }

public async Task<Aplication> CreateApplication(AddApplicationRequestDto addApplicationRequestDto)
{
    if (addApplicationRequestDto == null)
    {
        throw new ArgumentNullException(nameof(addApplicationRequestDto), "Can't be empty");
    }


    Aplication application = _mapper.Map<Aplication>(addApplicationRequestDto);


    await _appRepo.AddAsync(application);

    return application;
}


    public async Task<List<Aplication>> GetListApplications ()
    {
        List<Aplication> applications = 
        await _appRepo.GetAllAsync();

        return applications;
    }  

    public async Task<Aplication> GetApplicationAsync(long id)
    {
        Aplication aplication = 
        await _appRepo.GetApplicationByIdAsync(id);
    
        return aplication;
    }

    public async Task<bool> DeleteApplication (long id)
    {
        await _appRepo.DeleteAsync(id);

        if()
        {
            return true;
        }
        false;
    }
}
