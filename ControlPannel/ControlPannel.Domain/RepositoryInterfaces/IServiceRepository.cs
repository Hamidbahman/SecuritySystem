using System;
using ControlPannel.Domain.Entities;

namespace controlpannel.domain.RepositoryInterfaces;

public interface IServiceRepository
{
    Task<List<Service>> GetAllServicesByActeeIdAsync(long acteeId);
}
