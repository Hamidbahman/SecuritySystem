using System;
using System.Linq.Expressions;
using ControlPannel.Domain.Entities;

namespace controlpannel.domain.RepositoryInterfaces;

public interface IApplicationRepository
{
    Task<Aplication?> GetByIdAsync(long id);
    Task<List<Aplication>> GetAllAsync(Expression<Func<Aplication, object>> sortBy, bool descending);
    Task AddAsync(Aplication application);
    Task UpdateAsync(Aplication application);
    Task<bool> DeleteAsync(long id);





}