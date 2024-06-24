using CLients.Data.Interfaces;
using CLients.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CLients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController(IClientInterface client) : ControllerBase
    {
        private readonly IClientInterface _client = client;

        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync([FromForm] Client client)
        {
            await _client.CreateAsync(client);
            return Ok();
        }

        [HttpGet("CLients")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _client.GetAllAsync());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetByIdAsyn([FromForm] int id)
        {
            return Ok(await _client.GetByIdAsync(id));
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync([FromForm] int id)
        {
            await _client.DeleteAsync(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Client client)
        {
            await _client.UpdateAsync(client);
            return Ok();
        }

    }
}
