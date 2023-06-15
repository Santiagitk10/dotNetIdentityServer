using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Cotrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeShopController : ControllerBase
    {
        private ICoffeShopService CoffeeShopService { get; }

        public CoffeeShopController(ICoffeShopService coffeeShopService)
        {
            CoffeeShopService = coffeeShopService;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await CoffeeShopService.List());
        }
    }
}