using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestMatch.API.Application.Dtos;
using RestMatch.API.Application.Interfaces;

namespace RestMatch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private readonly IRateService _rateService;
        public RateController(IRateService rateService)
        {
            _rateService = rateService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateNewRewiew([FromBody]CreateReviewDto model)
        {
            await _rateService.CreateReviewRerate(model);
            return Ok();
        }
    }
}
