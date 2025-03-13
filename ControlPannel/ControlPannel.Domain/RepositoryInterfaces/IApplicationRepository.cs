using System;
using ControlPannel.Domain.Entities;

namespace controlpannel.domain.RepositoryInterfaces;

public interface IApplicationRepository
{
        Task<Aplication?> GetByIdAsync(long id);
        Task<List<Aplication>> GetAllAsync(string? sortField = null, bool descending = false);
        Task AddAsync(Aplication application);
        Task UpdateAsync(Aplication application);
        Task<bool> DeleteAsync(long id);





}