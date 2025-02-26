using Microsoft.AspNetCore.Mvc;
using FizzBuzzGameAPI.Models;
using FizzBuzzGameAPI.Services;

namespace FizzBuzzGameAPI.Controllers
{
    [ApiController]
    [Route("api/rules")]
    public class RulesController : ControllerBase
    {
        private readonly IRuleService _ruleService;

        public RulesController(IRuleService ruleService) => _ruleService = ruleService;

        [HttpGet]
        public async Task<IActionResult> GetRules()
        {
            var rules = await _ruleService.GetRules();
            return Ok(rules);
        }

        [HttpPost]
        public async Task<IActionResult> AddRule([FromBody] Rule rule)
        {
            return await _ruleService.AddRule(rule) != null ? Ok(_ruleService.AddRule(rule)) : BadRequest("Invalid or duplicate rule.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRule(int id){
            return await _ruleService.DeleteRule(id) ? Ok() : NotFound();
        }
 
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRule(int id, [FromBody] Rule rule){
            return await _ruleService.UpdateRule(id, rule) != null ? Ok(_ruleService.UpdateRule(id, rule)) : NotFound();
        }
    }
}

