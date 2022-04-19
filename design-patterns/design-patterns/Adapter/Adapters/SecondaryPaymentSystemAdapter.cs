using design_patterns.Adapter.ExternalAPIs;

namespace design_patterns.Adapter
{
    // Class that convert the model into the specific call of external API 
    public class SecondaryPaymentSystemAdapter : IPaymentAdapter
    {
        public void callsExternalPaymentSystem(Payment paymentModel)
        {
            var secondaryPayment = new SecondaryPaymentSystem(paymentModel.ammount, paymentModel.depositAccount) ;
            secondaryPayment.pay();
        }
    }
}
