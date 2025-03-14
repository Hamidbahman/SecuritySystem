using System;
using ControlPannel.Domain.Entities;



namespace controlpannel.domain.RepositoryInterfaces;
public interface IConfigurationLockRepository
{
    Task<ConfigurationLock?> GetByIdAsync(long id);
    Task<List<ConfigurationLock>> GetAllAsync(long applicationId);
    Task AddAsync(ConfigurationLock configurationLock);
    Task UpdateAsync(ConfigurationLock configurationLock);
    Task<bool> DeleteAsync(long id);
}
