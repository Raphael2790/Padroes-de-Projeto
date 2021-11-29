using Design_patterns.Facade.CrossCutting;
using Design_patterns.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Facade
{
    public class FacadeExecution
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

            var payment = new Payment { CreditCard = "5555 2222 4444 5555" };

            var paymentService = new CreditCardPaymentService(new CreditcardPaymentFacade(new PayPalGateway(), new ConfigurationManager()));

            var paymentResult = paymentService.MakePayment(order, payment);

            Console.WriteLine(paymentResult.Status);
        }
    }
}
