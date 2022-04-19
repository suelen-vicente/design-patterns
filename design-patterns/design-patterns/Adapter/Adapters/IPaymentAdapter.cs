namespace design_patterns.Adapter
{
    // Interface used to abstract the method responsible by calling the right external payment system.
    public interface IPaymentAdapter
    {
        void callsExternalPaymentSystem(Payment paymentModel);
    }
}
