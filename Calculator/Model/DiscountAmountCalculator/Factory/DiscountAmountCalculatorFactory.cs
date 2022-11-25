using System;

namespace Calculator.Model
{
    public class DiscountAmountCalculatorFactory : IDiscountAmountCalculatorFactory
    {
        public IDiscountAmountCalculator GetIDiscountAmountCalculator(CustomerType customerType)
        {
            IDiscountAmountCalculator amountCalculator = null;
            switch (customerType)
            {
                case CustomerType.Unregistered:
                    amountCalculator = new UnregisteredDiscountAmountCalculator();
                    break;
                case CustomerType.Registered:
                    amountCalculator = new RegisteredDiscountAmountCalculator();
                    break;
                case CustomerType.Valuable:
                    amountCalculator = new ValuableDiscountAmountCalculator();
                    break;
                case CustomerType.MostValuable:
                    amountCalculator = new MostValuableDiscountAmountCalculator();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(customerType), customerType, null);
            }

            return amountCalculator;
        }
    }
}