namespace Calculator.Model
{
    public class DiscountPercentProviderFactory : IDiscountPercentProviderFactory
    {
        public IDiscountPercentProvider CreateDiscountPercentProvider(int years)
        {
            return (years > 5) ? new FixedDiscountPercentProvider():new ByYearsDiscountPercentProvider(years);
        }
    }
}