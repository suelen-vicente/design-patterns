using System;
using System.Collections.Generic;

namespace design_patterns.Flyweight
{
    public class APIFactory
    {
        private static Dictionary<string, IAPIRequest> flyweights = new Dictionary<string, IAPIRequest>();
        public static IAPIRequest getApi(String key)
        {
            if (flyweights.ContainsKey(key))
            {
                return flyweights[key];
            }

            IAPIRequest api;

            switch (key)
            {
                case "Payment":
                    api = new PaymentAPI();
                    api.apiUrl = "apiPaymentUrl";
                    break;
                case "Taxes":
                    api = new TaxesAPI();
                    api.apiUrl = "apiTaxesUrl";
                    break;
                default:
                    throw new Exception("Unsupported api.");
            }
            flyweights.Add(key, api);
            return api;
        }
    }
}
