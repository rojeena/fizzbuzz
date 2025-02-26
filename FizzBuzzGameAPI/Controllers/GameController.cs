using Microsoft.AspNetCore.Mvc;
using FizzBuzzGameAPI.Models;
using FizzBuzzGameAPI.Services;

namespace FizzBuzzGameAPI.Controllers
{
    [ApiController]
    [Route("api/fizzbuzz")]
    public class GameController : ControllerBase
    {
        private readonly IRuleService _ruleService;
        private readonly IGameService _gameService;

        public GameController(IRuleService ruleService, IGameService gameService)
        {
            _ruleService = ruleService;
            _gameService = gameService;
        }

        [HttpGet]
        public IActionResult StartGame() => Ok(_gameService.GenerateNumber());

        [HttpPost]
        public async Task<IActionResult> ValidateAnswer([FromBody] GameAnswer answer)
        {
            var rules = await _ruleService.GetRules();
            var expectedAnswer = _gameService.GetExpectedAnswer(answer.Number, rules);
            bool isCorrect = expectedAnswer.Equals(answer.Answer, StringComparison.OrdinalIgnoreCase);
            return Ok(new { message = isCorrect, nextNumber = _gameService.GenerateNumber() });
        }
    }
}
