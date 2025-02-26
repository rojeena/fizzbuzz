using System.Collections.Generic;
using System.Linq;
using FizzBuzzGameAPI.Models;

namespace FizzBuzzGameAPI.Services
{
    public class RuleService : IRuleService
    {
        private readonly List<Rule> rules = new List<Rule>
        {
            new Rule { Id = 1, Divisor = 3, Text = "Fizz", Disabled = false },
            new Rule { Id = 2, Divisor = 5, Text = "Buzz", Disabled = false },
            new Rule { Id = 3, Divisor = 7, Text = "Bang", Disabled = false }
        };

        private bool IsDividedByZero(int divisor) => divisor <= 0;
        private bool AlreadyExists(int divisor) => rules.Any(r => r.Divisor == divisor);
        private Rule GetRule(int id) => rules.FirstOrDefault(r => r.Id == id);

        public async Task<List<Rule>> GetRules()
        {
            return await Task.FromResult(rules); 
        }

        public async Task<Rule> AddRule(Rule rule)
        {
            // Check if the divisor is zero or already exists
            if (IsDividedByZero(rule.Divisor) || AlreadyExists(rule.Divisor)) return await Task.FromResult<Rule>(null);            
            rule.Id = rules.Count + 1;
            rules.Add(rule);
            return await Task.FromResult(rule);
        }

        public async Task<bool> DeleteRule(int id)
        {
            // Check if there is only one rule
            if (rules.Count == 1) return false; 

            var rule = GetRule(id);
            if (rule == null) return await Task.FromResult(false);
            rules.Remove(rule);
            return await Task.FromResult(true);
        }

        public async Task<Rule> UpdateRule(int id, Rule rule)
        {
            // Check if the rule already exists
            var existingRule = GetRule(id);
            if (existingRule == null) return await Task.FromResult<Rule>(null);

            existingRule.Divisor = rule.Divisor;
            existingRule.Text = rule.Text;
            existingRule.Disabled = rule.Disabled;
            
            return await Task.FromResult(existingRule);
        }
    }
}