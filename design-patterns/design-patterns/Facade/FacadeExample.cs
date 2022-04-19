namespace design_patterns.Facade
{
    public enum Operation
    {
        credit,
        debit
    }
    public class FacadeExample
    {
        public void makePayment(Operation operation)
        {
            PaymentFacade paymentFacade = new PaymentFacade();

            if (operation == Operation.credit)
            {
                paymentFacade.processCreditPayment();
            }
            else
            {
                paymentFacade.processDebitPayment();
            }
        }
    }
}
