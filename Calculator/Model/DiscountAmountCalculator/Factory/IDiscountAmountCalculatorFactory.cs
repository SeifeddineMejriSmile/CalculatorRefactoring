namespace Calculator.Model
{
    public interface IDiscountAmountCalculatorFactory
    {
        IDiscountAmountCalculator GetIDiscountAmountCalculator(CustomerType customerType);
    }
}