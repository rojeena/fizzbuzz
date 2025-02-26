using System.Collections.Generic;
using FizzBuzzGameAPI.Models; 

namespace FizzBuzzGameAPI.Services
{
    public interface IGameService
    {
        int GenerateNumber();
        string GetExpectedAnswer(int number, List<Rule> rules);
    }
}