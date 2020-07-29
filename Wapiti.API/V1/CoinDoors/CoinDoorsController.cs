using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Wapiti.API.V1.CoinDoors
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoinDoorsController : ControllerBase
    {
        private readonly ILogger<CoinDoorsController> _logger;

        public CoinDoorsController(ILogger<CoinDoorsController> logger)
            => _logger = logger;

        /// <summary>
        /// Get door information for a given door by its id.
        /// 
        /// > http --verify=no https://localhost:5001/api/coindoors/{doorId} 
        /// 
        /// </summary>
        [HttpGet]
        [Route("{doorId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<CoinDoor>> Get(Guid doorId)
        {
            if (doorId.Equals(Guid.Empty))
                return NotFound();

            var cd = new CoinDoor()
            {
                Id = doorId,
                Name = "TestDoor",
                CreditCost = 1.00M,
                Location = "Tampa, FL - Wapiti's Lounge"
            };

            return Ok(cd);
        }
    }
}
