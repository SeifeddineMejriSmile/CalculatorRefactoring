using System;
using Calculator;
using Calculator.Model;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace CalculatorTest
{
    public class DiscountAmountCalculatorFactory
    {
        private IDiscountAmountCalculatorFactory _amountCalculatorFactory;

        [SetUp]
        public void Setup()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.Register();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            _amountCalculatorFactory = serviceProvider.GetService<IDiscountAmountCalculatorFactory>();
        }
         
        [TestCase(CustomerType.Unregistered, typeof(UnregisteredDiscountAmountCalculator))]
        [TestCase(CustomerType.Registered, typeof(RegisteredDiscountAmountCalculator))]
        [TestCase(CustomerType.Valuable, typeof(ValuableDiscountAmountCalculator))]
        [TestCase(CustomerType.MostValuable, typeof(MostValuableDiscountAmountCalculator))]
        public void MustReturnUnregisteredCalculatorWhereTypeIsUnregistered(CustomerType customerType, Type discountAmountCalculatorType)
        {
            var discountAmountCalculator = _amountCalculatorFactory.GetIDiscountAmountCalculator(customerType);
            Assert.NotNull(discountAmountCalculator);
            Assert.IsInstanceOf(discountAmountCalculatorType, discountAmountCalculator);
        }

    }
}