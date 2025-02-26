namespace FizzBuzzGameAPI.Models
{
    public class Rule
    {
        public int Id { get; set; }
        public int Divisor { get; set; }
        public string Text { get; set; }
        public bool Disabled { get; set; }
    }
}