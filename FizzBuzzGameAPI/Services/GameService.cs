using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzzGameAPI.Models;

namespace FizzBuzzGameAPI.Services
{
    public class GameService : IGameService
    {
        private static readonly Random random = new Random();

        public int GenerateNumber() => random.Next(1, 999);

        public string GetExpectedAnswer(int number, List<Rule> rules)
        {
            // var expected = rules
            //     .Where(r => number % r.Divisor == 0)
            //     .OrderBy(r => r.Divisor)
            //     .Select(r => r.Text)
            //     .ToList();
            
            // return expected.Any() ? string.Join("", expected) : number.ToString();

            var expected = rules
            .Where(r => number % r.Divisor == 0)
            .OrderBy(r => r.Divisor)
            .FirstOrDefault();

            return expected != null ? expected.Text : number.ToString();

        }
    }
}
