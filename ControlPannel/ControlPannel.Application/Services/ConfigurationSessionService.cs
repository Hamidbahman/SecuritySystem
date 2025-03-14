using System;
using AutoMapper;
using controlpannel.application.Dtos.ConfigurationSessionDtos;
using controlpannel.domain.RepositoryInterfaces;
using ControlPannel.Domain.Entities;


namespace controlpannel.application.Services;
public class ConfigurationSessionService
{
    private readonly IConfigurationSessionRepository _repository;
    private readonly IMapper _mapper;

    public ConfigurationSessionService(IConfigurationSessionRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ConfigurationSessionDto>> GetAllByApplicationIdAsync(long applicationId)
    {
        var sessions = await _repository.GetAllAsync(applicationId);
        return _mapper.Map<List<ConfigurationSessionDto>>(sessions);
    }

    public async Task<ConfigurationSessionDto?> GetByIdAsync(long id)
    {
        var session = await _repository.GetByIdAsync(id);
        return _mapper.Map<ConfigurationSessionDto>(session);
    }

    public async Task AddAsync(AddConfigurationSessionRequestDto dto)
    {
        var entity = _mapper.Map<ConfigurationSession>(dto);
        await _repository.AddAsync(entity);
    }

    public async Task UpdateAsync(UpdateConfigurationSessionRequestDto dto)
    {
        var entity = _mapper.Map<ConfigurationSession>(dto);
        await _repository.UpdateAsync(entity);
    }

    public async Task<bool> DeleteAsync(long id)
    {
        return await _repository.DeleteAsync(id);
    }
}
