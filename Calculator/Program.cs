using System;
using System.ComponentModel.Design;
using Calculator.Model;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.Register();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var calculator = serviceProvider.GetService<ICalculator>();
            var amount = calculator?.Calculate(100, 2, 6);
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Amount {amount}");
        }

       
    }
}
