namespace design_patterns.Flyweight
{
    public class TaxesAPI : IAPIRequest
    {
        public string apiUrl { get; set; }
        public static int numberOfInstances;

        public TaxesAPI()
        {
            apiUrl = "taxAPIUrl";
            numberOfInstances++;
        }

        public void callAPI()
        {
            // calls taxes API
        }
    }
}
