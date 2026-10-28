namespace arithmeticmvc.Models
{
    public class Calculator
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public required string operation { get; set; }
        public double Result { get; set; }
    }
}
