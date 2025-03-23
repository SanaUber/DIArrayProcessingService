using DIArrayProcessingService.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace DIArrayProcessingService.Controllers
{
    [Route("api/sort")]
    [ApiController]
    public class SortController : ControllerBase
    {
        private readonly INumberArrayServices _numberArrayServices;

        public SortController(INumberArrayServices sortService)
        {
            _numberArrayServices = sortService;
        }

        [HttpPost("sort-in-loop")]
        public IActionResult SortInLoop([FromBody] int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return BadRequest("Input array cannot be empty.");

            var sortedNumbers = _numberArrayServices.SortInLoop(numbers);
            return Ok(sortedNumbers);
        }

        [HttpPost("sort-outside-loop")]
        public IActionResult SortOutsideLoop([FromBody] int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return BadRequest("Input array cannot be empty.");

            var sortedNumbers = _numberArrayServices.SortOutsideLoop(numbers);
            return Ok(sortedNumbers);
        }
    }
}
