using System;
using controlpannel.domain.RepositoryInterfaces;
using ControlPannel.Domain.Entities;
using ControlPannel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace controlpannel.infrastructure.Repositories;

public class ServiceRepository : IServiceRepository
{
    private readonly SecurityDbContext _context;
    public ServiceRepository(SecurityDbContext context)
    {
        _context = context;
    }

    public async Task<List<Service>> GetAllServicesByActeeIdAsync(long acteeId)
    {
        return await _context.Services
            .Where(s=> s.ActeeId == acteeId)
            .ToListAsync();
    }


}