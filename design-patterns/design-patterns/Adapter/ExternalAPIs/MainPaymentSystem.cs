namespace design_patterns.Adapter.ExternalAPIs
{
    public class MainPaymentSystem
    {
        // Attributes of this specific API
        public double total { get; set; }
        public string account { get; set; }

        public MainPaymentSystem(double total, string account)
        {
            this.total = total;
            this.account = account;
        }

        public void pay()
        {
            //configure and call external API
        }
    }
}
