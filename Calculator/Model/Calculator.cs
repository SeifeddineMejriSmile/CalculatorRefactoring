namespace Calculator.Model
{
    public class Calculator : ICalculator
    {
        private readonly IDiscountPercentProviderFactory _discountPercentProviderFactory;
        private readonly IDiscountAmountCalculatorFactory _amountCalculatorFactory;
        public Calculator(IDiscountPercentProviderFactory discountPercentProviderFactory, IDiscountAmountCalculatorFactory amountCalculatorFactory)
        {
            _discountPercentProviderFactory = discountPercentProviderFactory;
            _amountCalculatorFactory = amountCalculatorFactory;
        }

        public decimal Calculate(decimal amount, int type, int years)
        {
            var discountPercentProvider =  _discountPercentProviderFactory.CreateDiscountPercentProvider(years);
            var discountPercent = discountPercentProvider.GetPercentDiscount();
            var customerType = (CustomerType)type;
            var amountCalculator =_amountCalculatorFactory.GetIDiscountAmountCalculator(customerType);
            var result = amountCalculator.Calculate(amount, discountPercent);
            return result;
        }
    }
}