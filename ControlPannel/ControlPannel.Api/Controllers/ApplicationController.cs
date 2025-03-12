using AutoMapper;
using controlpannel.api.Dtos;
using controlpannel.application.Services;
using ControlPannel.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace controlpannel.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly ApplicationService _appService;
        private readonly IMapper _mapper;

        public ApplicationController (ApplicationService appService,
            IMapper mapper)
        {
            _mapper = mapper;
            _appService = appService;
        }

        [HttpPost("")]
        public async Task<Aplication> AddApplicationSingleAsync (AddApplicationRequestDto addApplicationRequestDto)
        {
            if(addApplicationRequestDto == null)
            {

            }
            return application;
        }


        [HttpPost("")]
        public async Task<List<Aplication> GetAllApplications ()
        {
            if ()
            {

            }

            return ;
        }

        [HttpPost("")]
        public async Task<bool> RemoveApplication (long id)
        {
            if()

            return Ok;
        }

        [HttpPost("")]
        public async Task<Aplication> UpdateApplication (Aplication application)
        {
            if()

            return Ok;
        }

        
    }
}
