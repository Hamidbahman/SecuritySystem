using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using controlpannel.Application.Dtos;
using controlpannel.domain.RepositoryInterfaces;
using controlpannel.infrastructure.Repositories;
using ControlPannel.Domain.Entities;

namespace controlpannel.application.Services
{
    public class ApplicationService
    {
        private readonly IApplicationRepository _appRepo;
        private readonly IMapper _mapper;
        
        public ApplicationService(IApplicationRepository appRepo, IMapper mapper)
        {
            _appRepo = appRepo;
            _mapper = mapper;
        }

        public async Task<ApplicationDto> CreateApplicationAsync(AddApplicationRequestDto dto)
        {
            var application = _mapper.Map<Aplication>(dto);
            await _appRepo.AddAsync(application);
            return _mapper.Map<ApplicationDto>(application);
        }

        public async Task<ApplicationDto?> GetApplicationByIdAsync(long id)
        {
            var application = await _appRepo.GetByIdAsync(id);
            return application != null ? _mapper.Map<ApplicationDto>(application) : null;
        }

        public async Task<List<ApplicationDto>> GetAllApplicationsAsync(string? sortField = null, bool descending = false)
        {
            var applications = await _appRepo.GetAllAsync(sortField, descending);
            return _mapper.Map<List<ApplicationDto>>(applications);
        }

        public async Task<bool> UpdateApplicationAsync(UpdateApplicationRequestDto dto)
        {
            var application = await _appRepo.GetByIdAsync(dto.Id);
            if (application == null) return false;
            _mapper.Map(dto, application);
            await _appRepo.UpdateAsync(application);
            return true;
        }

        public async Task<bool> DeleteApplicationAsync(long id)
        {
            return await _appRepo.DeleteAsync(id);
        }
    }
}
