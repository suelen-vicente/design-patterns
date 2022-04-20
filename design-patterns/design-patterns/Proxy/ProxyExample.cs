namespace design_patterns.Proxy
{
    public class ProxyExample
    {
        public void remoteProxyToPaymentAPI()
        {
            // Create proxy and request a service
            PaymentAPIProxy proxy = new PaymentAPIProxy();
            proxy.encodeRequest();

        }
    }
}
