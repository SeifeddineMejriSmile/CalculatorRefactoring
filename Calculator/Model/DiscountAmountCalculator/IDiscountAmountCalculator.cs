using System.Reflection.Metadata.Ecma335;

namespace Calculator.Model
{
    public interface IDiscountAmountCalculator
    {
        public decimal Calculate(decimal amount, decimal discount);
    }
}