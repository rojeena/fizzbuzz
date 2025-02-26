using System.Collections.Generic;
using FizzBuzzGameAPI.Models;

namespace FizzBuzzGameAPI.Services
{
    public interface IRuleService
    {
        Task<List<Rule>> GetRules();
        Task<Rule> AddRule(Rule rule);
        Task<bool> DeleteRule(int id);
        Task<Rule> UpdateRule(int id, Rule rule);
    }
}