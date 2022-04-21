namespace design_patterns.Flyweight
{
    public class PaymentAPI : IAPIRequest
    {
        public string apiUrl { get; set; }
        public static int numberOfInstances;

        public PaymentAPI()
        {
            apiUrl = "paymentAPIUrl";
            numberOfInstances++;
        }

        public void callAPI()
        {
            // calls payment API
        }
    }
}
