using Calculator.Model;
using Moq;
using NUnit.Framework;

namespace CalculatorTest
{
    public class CalculatorFactoryTest
    {
        private Mock<IDiscountPercentProviderFactory> _discountPercentProviderFactory;
        private Mock <IDiscountAmountCalculatorFactory> _amountCalculatorFactory;
        private Mock<IDiscountPercentProvider> _discountPercentProvider;
        private Mock<IDiscountAmountCalculator> _discountAmountCalculator;
        [SetUp]
        public void Setup()
        {
            _discountPercentProviderFactory = new Mock<IDiscountPercentProviderFactory>();
            _amountCalculatorFactory = new Mock<IDiscountAmountCalculatorFactory>();
            _discountPercentProvider = new Mock<IDiscountPercentProvider>();
            _discountAmountCalculator = new Mock<IDiscountAmountCalculator>();
            _discountPercentProviderFactory.Setup(factory => factory.CreateDiscountPercentProvider(1))
                .Returns(_discountPercentProvider.Object);
            _amountCalculatorFactory.Setup(factory => factory.GetIDiscountAmountCalculator(CustomerType.Unregistered))
                .Returns(_discountAmountCalculator.Object);
        }

        [Test]
        public void VerifyCalls()
        {
            var calculator = new Calculator.Model.Calculator(_discountPercentProviderFactory.Object, _amountCalculatorFactory.Object);
            calculator.Calculate(0, 1, 1);
            _discountPercentProviderFactory.Verify(factory => factory.CreateDiscountPercentProvider(1), Times.Once);
            _amountCalculatorFactory.Verify(factory => factory.GetIDiscountAmountCalculator(CustomerType.Unregistered), Times.Once);
        }

    }
}