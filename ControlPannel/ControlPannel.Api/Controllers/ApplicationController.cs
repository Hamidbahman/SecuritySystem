using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using controlpannel.application.Services;
using controlpannel.Application.Dtos;
using controlpannel.application.Dtos;

namespace controlpannel.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly ApplicationService _applicationService;
        
        public ApplicationController(ApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] AddApplicationRequestDto dto)
        {
            var result = await _applicationService.CreateApplicationAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPost("getById")]
        public async Task<IActionResult> GetById([FromBody] long id)
        {
            var result = await _applicationService.GetApplicationByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost("getAll")]
        public async Task<IActionResult> GetAll([FromBody] SortingRequestDto sortingRequest)
        {
            var results = await _applicationService.GetAllApplicationsAsync(sortingRequest.SortField, sortingRequest.Descending);
            return Ok(results);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] UpdateApplicationRequestDto dto)
        {
            var success = await _applicationService.UpdateApplicationAsync(dto);
            if (!success) return NotFound();
            return NoContent();
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] long id)
        {
            var success = await _applicationService.DeleteApplicationAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}
