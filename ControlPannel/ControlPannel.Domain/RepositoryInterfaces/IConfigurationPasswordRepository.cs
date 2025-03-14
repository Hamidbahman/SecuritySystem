using System;
using ControlPannel.Domain.Entities;



namespace controlpannel.domain.RepositoryInterfaces;
public interface IConfigurationPasswordRepository
{
    Task<ConfigurationPassword?> GetByIdAsync(long id);
    Task<List<ConfigurationPassword>> GetAllAsync(long applicationId);
    Task AddAsync(ConfigurationPassword configurationPassword);
    Task UpdateAsync(ConfigurationPassword configurationPassword);
    Task<bool> DeleteAsync(long id);
}
