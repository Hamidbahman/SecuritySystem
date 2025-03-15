using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/access")]
    public class UserAccessController : ControllerBase
    {
        private readonly UserAccessService _userAccessService;

        public UserAccessController(UserAccessService userAccessService)
        {
            _userAccessService = userAccessService;
        }

]        [HttpPost("user-access")]
        public async Task<IActionResult> GetUserAccess([FromBody] UserAccessRequest request)
        {
            try
            {
                var result = await _userAccessService.GetUserAccessAsync(request.UserId, request.ClientId);
                return Ok(result);  
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { error = ex.Message });  
            }
        }

        [HttpPost("user-applications")]
        public async Task<IActionResult> GetUserApplications([FromBody] UserApplicationsRequest request)
        {
            try
            {
                var result = await _userAccessService.GetUserApplicationsAsync(request.UserId);
                return Ok(result);  
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { error = ex.Message });  
            }
        }
    }

    // Model for the user access request body
    public class UserAccessRequest
    {
        public long UserId { get; set; }
        public string ClientId { get; set; }
    }

    // Model for the user applications request body
    public class UserApplicationsRequest
    {
        public long UserId { get; set; }
    }
}
