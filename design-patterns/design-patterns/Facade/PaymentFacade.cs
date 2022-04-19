namespace design_patterns.Facade
{
    public class PaymentFacade
    {
        CreditCardPayment creditCard;
        DebitCardPayment debitCard;
        TransferPayment transferPayment;
        ExternalTaxCalculator externalTaxCalculator;

        public PaymentFacade()
        {
            creditCard = new CreditCardPayment();
            debitCard = new DebitCardPayment();
            transferPayment = new TransferPayment();
            externalTaxCalculator = new ExternalTaxCalculator();
        }

        public void processCreditPayment()
        {
            externalTaxCalculator.callTaxCalculator();
            creditCard.callCreditCardAPI();
            transferPayment.callTransferFundsAPI();
        }

        public void processDebitPayment()
        {
            externalTaxCalculator.callTaxCalculator();
            debitCard.callDebitCardAPI();
            transferPayment.callTransferFundsAPI();
        }
    }
}
