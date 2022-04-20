namespace design_patterns.Proxy
{
    public class PaymentAPIProxy : PaymentAPI
    {
        private PaymentAPI paymentAPI;

        public void encodeRequest()
        {
            //DO some logic in here
            paymentAPI.encodeRequest();
        }
    }
}
