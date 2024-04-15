using AutoMapper;
using Contracts.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;
        /*[HttpPost]
        public Task<IActionResult> Create([FromBody] CreateUserRequest request, CancellationToken token)
        {
            await _service.CreateAsync(mapper.Map<Instructor>(request), token);

            return Ok();
        }*/
    }
}
