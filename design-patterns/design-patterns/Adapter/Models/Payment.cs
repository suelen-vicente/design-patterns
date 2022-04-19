using System;

namespace design_patterns.Adapter
{
    //All the possible external payment systems that could be used at the same time in POS System
    public enum ExternalPaymentSystem
    {
        MainPaymentSystem,
        SecondaryPaymentSystem
    }
    
    // Class that will abstract what information is needed to make a payment, regardless the external system
    public class Payment
    {
        public ExternalPaymentSystem externalPaymentSystem { get; set; }
        public Double ammount { get; set; }
        public String depositAccount { get; set; }
    }
}
