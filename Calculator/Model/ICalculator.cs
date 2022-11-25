namespace Calculator.Model
{
    public interface ICalculator
    {
        public decimal Calculate(decimal amount, int type, int years);
    }
}