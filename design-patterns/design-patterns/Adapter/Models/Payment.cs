using System;

namespace design_patterns.Adapter
{
    public enum ExternalPaymentSystem
    {
        MainPaymentSystem,
        SecondaryPaymentSystem
    }
    public class Payment
    {
        public ExternalPaymentSystem externalPaymentSystem { get; set; }
        public Double ammount { get; set; }
        public String depositAccount { get; set; }
    }
}
