using System;
using AutoMapper;
using controlpannel.application.Dtos.ConfigurationLockDtos;
using controlpannel.domain.RepositoryInterfaces;
using ControlPannel.Domain.Entities;


namespace controlpannel.application.Services;
public class ConfigurationLockService
{
    private readonly IConfigurationLockRepository _repository;
    private readonly IMapper _mapper;

    public ConfigurationLockService(IConfigurationLockRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ConfigurationLockDto>> GetAllByApplicationIdAsync(long applicationId)
    {
        var locks = await _repository.GetAllAsync(applicationId);
        return _mapper.Map<List<ConfigurationLockDto>>(locks);
    }

    public async Task<ConfigurationLockDto?> GetByIdAsync(long id)
    {
        var lockConfig = await _repository.GetByIdAsync(id);
        return _mapper.Map<ConfigurationLockDto>(lockConfig);
    }

    public async Task AddAsync(AddConfigurationLockRequestDto dto)
    {
        var entity = _mapper.Map<ConfigurationLock>(dto);
        await _repository.AddAsync(entity);
    }

    public async Task UpdateAsync(UpdateConfigurationLockRequestDto dto)
    {
        var entity = _mapper.Map<ConfigurationLock>(dto);
        await _repository.UpdateAsync(entity);
    }

    public async Task<bool> DeleteAsync(long id)
    {
        return await _repository.DeleteAsync(id);
    }
}
