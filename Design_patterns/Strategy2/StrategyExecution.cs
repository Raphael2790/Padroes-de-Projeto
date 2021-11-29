using Design_patterns.Facade.CrossCutting;
using Design_patterns.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Strategy2
{
    public static class StrategyExecution
    {
        public static void Execute()
        {
            var products = new List<Product>
            {
                new Product {Name = "Tenis Adidas", Price = new Random().Next(500) },
                new Product {Name = "Camisa Boliche", Price = new Random().Next(500)},
                new Product {Name = "Raquete de Tenis", Price = new Random().Next(500)}
            };

            var order = new Order { Id = Guid.NewGuid(), Products = products };

            var creditCardPayment = new Payment 
            {
                CreditCard = "5555 2222 4444 5555",
                PaymentType = PaymentType.CreditCard
            };

            var transferPayment = new Payment
            {
                PaymentType = PaymentType.TranferBetweenAccounts,
                AccountNumber = "32909-9"
            };

            var debitPayment = new Payment
            {
                CreditCard = "5555 2222 4444 5555",
                PaymentType = PaymentType.DebitCard
            };

            var creditOrder = new OrderService(new CreditCardPaymentService(new CreditcardPaymentFacade(new PayPalGateway(), new ConfigurationManager())));
            var creditPayment = creditOrder.MakePayment(order, creditCardPayment);
            Console.WriteLine(creditPayment.Status);

            Console.WriteLine("--------------------------------------------------");

            var accountTranferOrder = new OrderService(new TranferBetweenAccountsPaymentService(new TranferBetweenAccountsPaymentFacade()));
            var accountTranferPayment = accountTranferOrder.MakePayment(order, transferPayment);
            Console.WriteLine(accountTranferPayment.Status);

            Console.WriteLine("--------------------------------------------------");

            var debitCardOrder = new OrderService(new DebitCardPaymentService(new DebitCardPaymentFacade(new PayPalGateway(), new ConfigurationManager())));
            var debitCardPayment = debitCardOrder.MakePayment(order, debitPayment);
            Console.WriteLine(debitCardPayment.Status);

            Console.WriteLine("--------------------------------------------------");

            //Usando o Payment Factory
            var creditOrder2 = new OrderService(PaymentFactory.CreatePayment(creditPayment.PaymentType));
            var creditPayment2 = creditOrder2.MakePayment(order, creditCardPayment);
            Console.WriteLine(creditPayment2.Status);

            Console.WriteLine("--------------------------------------------------");

            var accountTranferOrder2 = new OrderService(PaymentFactory.CreatePayment(accountTranferPayment.PaymentType));
            var accountTranferPayment2 = accountTranferOrder2.MakePayment(order, transferPayment);
            Console.WriteLine(accountTranferPayment2.Status);

            Console.WriteLine("--------------------------------------------------");

            var debitCardOrder2 = new OrderService(PaymentFactory.CreatePayment(debitCardPayment.PaymentType));
            var debitCardPayment2 = debitCardOrder2.MakePayment(order, debitPayment);
            Console.WriteLine(debitCardPayment2.Status);

            Console.WriteLine("--------------------------------------------------");

        }
    }
}
