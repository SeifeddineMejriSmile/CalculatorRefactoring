using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Model
{
    public class DiscountAmountCalculatorFactory : IDiscountAmountCalculatorFactory
    {
        private readonly IEnumerable<IDiscountAmountCalculator> _discountAmountCalculators;

        public DiscountAmountCalculatorFactory(IEnumerable<IDiscountAmountCalculator> discountAmountCalculators)
        {
            _discountAmountCalculators = discountAmountCalculators;
        }

        public IDiscountAmountCalculator GetIDiscountAmountCalculator(CustomerType customerType)
        {
            var amountCalculator = _discountAmountCalculators.FirstOrDefault(p=> p.CustomerType == customerType);
            return amountCalculator;
        }
    }
}