using System;
using Calculator.Model;
using NUnit.Framework;

namespace CalculatorTest
{
    public class DiscountAmountCalculatorFactory
    {
        private IDiscountAmountCalculatorFactory _amountCalculatorFactory;

        [SetUp]
        public void Setup()
        {
            _amountCalculatorFactory = new Calculator.Model.DiscountAmountCalculatorFactory();
        }

        [Test]
        [TestCase(-1)]
        public void MustReturnUnregisteredCalculatorWhereTypeIsUnregistered(CustomerType customerType, Type discountAmountCalculatorType)
        {
            var discountAmountCalculator = _amountCalculatorFactory.GetIDiscountAmountCalculator(CustomerType.Unregistered);
            Assert.NotNull(discountAmountCalculator);
            Assert.IsInstanceOf( typeof(UnregisteredDiscountAmountCalculator), discountAmountCalculator);
        }
    }
}