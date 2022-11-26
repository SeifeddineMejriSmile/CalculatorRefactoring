namespace Calculator.Model
{
    public class UnregisteredDiscountAmountCalculator : IDiscountAmountCalculator
    {
        public CustomerType CustomerType => CustomerType.Unregistered;

        public decimal Calculate(decimal amount, decimal discount)
        {
            return amount;
        }
    }
}