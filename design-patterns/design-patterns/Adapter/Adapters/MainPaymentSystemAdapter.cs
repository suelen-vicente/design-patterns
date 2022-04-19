using design_patterns.Adapter.ExternalAPIs;

namespace design_patterns.Adapter
{
    public class MainPaymentSystemAdapter : IPaymentAdapter
    {
        public void callsExternalPaymentSystem(Payment paymentModel)
        {
            var mainPayment = new MainPaymentSystem(paymentModel.ammount, paymentModel.depositAccount);
            mainPayment.pay();
        }
    }
}
