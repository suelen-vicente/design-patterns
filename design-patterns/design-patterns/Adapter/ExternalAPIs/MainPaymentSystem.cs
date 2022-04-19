using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter.ExternalAPIs
{
    public class MainPaymentSystem
    {
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
