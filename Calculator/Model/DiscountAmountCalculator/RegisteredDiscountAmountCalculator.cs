namespace Calculator.Model
{
    public class RegisteredDiscountAmountCalculator : IDiscountAmountCalculator
    {
        public CustomerType CustomerType => CustomerType.Registered;

        public decimal Calculate(decimal amount, decimal discount)
        {
            var result = (amount - (0.1m * amount)) - discount * (amount - (0.1m * amount));
            return result;
        }
    }
}