using Discogs.Infra.Models;
using Discogs.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Discogs.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DiscogsController : ControllerBase
    {
        private readonly ILogger<DiscogsController> _logger;

        public DiscogsController(ILogger<DiscogsController> logger)
        {
            _logger = logger;
        }
        private static DiscogsApiClient CreateDiscogsApiClient()
        {
            var environment = DiscogsApiEnvironment.CreateDefault();
            return DiscogsApiClient.Create(environment);
        }



        // GET: api/<DiscogsController>
        [HttpGet("{num:int=5}")]

        public async Task<IEnumerable<Release>> Get(int num)
        {

            var client = CreateDiscogsApiClient();
            var db = client.Database;
            var searchResults = await db.Search();

            var rng = new Random();
            return Enumerable.Range(1, num).Select(n => searchResults.Releases[rng.Next(searchResults.Releases.Count)]);

  
        }

    }
}
