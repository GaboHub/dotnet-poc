using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet_api.Services;
using dotnet_api.Modelo;

namespace dotnet_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly ClientService _clientService;

        public ClientController(ILogger<ClientController> logger, ClientService clientService)
        {
            _logger = logger;
            _clientService = clientService;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clientService.GetClients());
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var client = _clientService.GetClient(id);
            if(client == null) {

                return NotFound("Client not found");
            }
            return Ok(_clientService.GetClient(id));
        }

        [HttpPost("add")]
        public IActionResult addClient(Client newClient)
        {
            _clientService.AddClient(newClient);
            return CreatedAtAction(nameof(addClient), newClient);
        }
    }
}
