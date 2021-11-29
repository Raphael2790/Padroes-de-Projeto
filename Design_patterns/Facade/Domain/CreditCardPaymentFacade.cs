using Design_patterns.Facade.CrossCutting;

namespace Design_patterns.Facade.Domain
{
    class CreditcardPaymentFacade : ICreditCardPaymentFacade
    {
        private IPayPalGateway _payPalGateway;
        private IConfigurationManager _configurationManager;

        public CreditcardPaymentFacade(IPayPalGateway payPalGateway, IConfigurationManager configurationManager)
        {
            _payPalGateway = payPalGateway;
            _configurationManager = configurationManager;
        }

        public bool MakePayment(Order order, Payment payment)
        {
            var apiKey = _configurationManager.GetValue("apiKey");
            var encriptionKey = _configurationManager.GetValue("encriptionKey");

            var serviceKey = _payPalGateway.GetPayPalServiceKey(apiKey, encriptionKey);
            var cardHashKey = _payPalGateway.GetCardHashKey(serviceKey, payment.CreditCard);

            var paymentResult = _payPalGateway.CommitTransaction(cardHashKey, order.Id.ToString(), payment.Total);

            return paymentResult;
        }
    }
}
