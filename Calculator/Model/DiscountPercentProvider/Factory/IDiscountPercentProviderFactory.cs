namespace Calculator.Model
{
    public interface IDiscountPercentProviderFactory
    {
        IDiscountPercentProvider CreateDiscountPercentProvider(int years);
    }
}