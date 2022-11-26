using Calculator.Model;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator
{
    public static class StartUp
    {
        public static IServiceCollection Register(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDiscountAmountCalculator, MostValuableDiscountAmountCalculator>();
            serviceCollection.AddTransient<IDiscountAmountCalculator, RegisteredDiscountAmountCalculator>();
            serviceCollection.AddTransient<IDiscountAmountCalculator, UnregisteredDiscountAmountCalculator>();
            serviceCollection.AddTransient<IDiscountAmountCalculator, ValuableDiscountAmountCalculator>();
            serviceCollection.AddTransient<IDiscountAmountCalculatorFactory, DiscountAmountCalculatorFactory>();
            serviceCollection.AddTransient<IDiscountPercentProviderFactory, DiscountPercentProviderFactory>();
            serviceCollection.AddTransient<ICalculator, Model.Calculator>();
            return serviceCollection;
        }
    }
}