using System;
using System.Data.Common;
using ControlPannel.Domain.Entities;

namespace controlpannel.application.Services;

public class ApplicationPasswordService
{
    private readonly ConfigurationPasswordRepository _passwordRepo;

    public ApplicationPasswordService (ConfigurationPasswordRepository passwordRepo)
    {
        _passwordRepo = passwordRepo;
    }


    public async Task<ConfigurationPassword> GetAllApplicationPassword(long applicationId)
    {
        ConfigurationPassword applicationPassword = 
        await _passwordRepo.GetConfigurationPassword(applicationId);

        if(applicationPassword == null)
        {
            return null;
        }

        return applicationPassword;
    }

    public async Task<bool> AddApplicationPassword(AddConfigurationPasswordRequestDto addApplicationPasswordRequestDto)
    {
            if(addApplicationPasswordRequestDto == null)
            {
                return null;
            }

            //Map RequestDto to ConfigurationPassword

            await _passwordRepo.AddAsync();

            return null;
    }


    public async Task<ConfigurationPassword> UpdateConfigurationPassword (ConfigurationUpdateRequestDto configurationUpdateRequestDto)
    {
        if(configurationUpdateRequestDto == null)
        {
            return null;
        }

        // Map UpdateRequest to ConfigurationPassword

        await _passwordRepo.UpdateAsync();

        return null;
    }


    public async Task<bool> DeleteAsync (long configurationPasswordId)
    {
        await _passwordRepo.RemoveAsync(configurationPasswordId);

        return true;
    }

    

}
